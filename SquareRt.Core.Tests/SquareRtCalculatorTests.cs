using NUnit.Framework;

namespace SquareRt.Core.Tests
{
   [TestFixture]
   public class SquareRtCalculatorTests
   {
      private ISquareRtCalculator calc;

      [SetUp]
      public void SetUp()
      {
         calc = new SquareRtCalculator();
      }

      [Test]
      public void Calculate_4_Returns2()
      {
         var squareRoot = calc.Calculate(4);
         Assert.AreEqual(2, squareRoot);
      }
   }
}