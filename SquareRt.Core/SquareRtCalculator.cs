using System;

namespace SquareRt.Core
{
	public class SquareRtCalculator : ISquareRtCalculator
	{
		public double Calculate(double number) => Math.Sqrt(number);
	}
}
