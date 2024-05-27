namespace Calculator
{
    internal interface ICalc
    {
        double Result { get; set; }
        void Sum(double x);
        void Sub(double x);
        void Multiply(double x);
        void Divide(double x);
        event EventHandler<EventArgs> MyEventHandler;
        void CancelLast() { }
    }
}
