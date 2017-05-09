using Moq;
using NUnit.Framework;
using SquareRt.Core.ViewModels;

namespace SquareRt.Core.Tests.ViewModels
{
    [TestFixture]
    public class SquareRtViewModelTests
    {
        private Mock<ISquareRtCalculator> calculator;
        private SquareRtViewModel viewModel;

        [SetUp]
        public void SetUp()
        {
            calculator = new Mock<ISquareRtCalculator>();
            viewModel = new SquareRtViewModel(calculator.Object);
            viewModel.ShouldAlwaysRaiseInpcOnUserInterfaceThread(false);
        }

        [Test]
        public void SettingNumber_RaisesPropertyChanged()
        {
            // Arrange
            var propertyChangedRaised = false;
            viewModel.PropertyChanged +=
               (s, e) => propertyChangedRaised = (e.PropertyName == "Number");

            // Act
            viewModel.Number = 1;

            // Assert
            Assert.IsTrue(propertyChangedRaised);
        }

        [Test]
        public void SettingNumber_CalculatesResult()
        {
            // Arrange
            calculator.Setup(c => c.Calculate(It.IsAny<double>()))
                       .Returns(2);
            // Act
            viewModel.Number = 4;

            // Assert
            Assert.AreEqual(2, viewModel.Result);
        }

        [Test]
        public void SettingNumber_RaisesPropertyChangedForResult()
        {
            // Arrange
            calculator.Setup(c => c.Calculate(It.IsAny<double>()))
                       .Returns(2);

            var propertyChangedRaised = false;
            viewModel.PropertyChanged +=
               (s, e) => propertyChangedRaised = (e.PropertyName == "Result");

            // Act
            viewModel.Number = 1;

            // Assert
            Assert.IsTrue(propertyChangedRaised);
        }
    }
}
