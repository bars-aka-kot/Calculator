﻿namespace Calculator
{
    public class CalculatorDivideByZeroException : CalculatorExeption
    {
        public CalculatorDivideByZeroException()
        {
        }
        public CalculatorDivideByZeroException(string error) : base(error)
        {
        }
    }
}
