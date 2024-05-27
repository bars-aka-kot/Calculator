namespace Calculator
{
    internal class Calc : ICalc
    {
        public double Result { set; get; } = 0;

        public event EventHandler<EventArgs>? MyEventHandler;
        public Stack<double> LastResult = new Stack<double>();
        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }
        public void Divide(double x)
        {
            if (x == 0)
            {
                throw new CalculatorDivideByZeroException();
            }
            Result /= x;
            Console.Write("Деление: ");
            PrintResult();
            LastResult.Push(Result);
        }

        public void Multiply(double x)
        {
            Result *= x;
            Console.Write("Умножение: ");
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sub(double x)
        {
            Result -= x;
            Console.Write("Вычитание: ");
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sum(double x)
        {
            Result += x;
            Console.Write("Сложение: ");
            PrintResult();
            LastResult.Push(Result);
        }
        public void CancelLast()
        {
            LastResult.Pop();
            Result = LastResult.Pop();
            Console.Write("Галя, у нас отмена: ");
            PrintResult();
        }
    }
}
