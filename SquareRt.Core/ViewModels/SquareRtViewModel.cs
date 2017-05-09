using MvvmCross.Core.ViewModels;

namespace SquareRt.Core.ViewModels
{
    public class SquareRtViewModel : MvxViewModel
    {
        readonly ISquareRtCalculator calculator;

        public SquareRtViewModel(ISquareRtCalculator calculator)
        {
            this.calculator = calculator;
        }

        double number;
		public double Number
		{
		    get { return number; }
		    set 
            { 
                if (SetProperty(ref number, value))
                Result = calculator.Calculate(number);   
            }
        }

		double result;
		public double Result
		{
			get { return result; }
			set { SetProperty(ref result, value); }
        }
    }
}
