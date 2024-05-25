namespace Calculator
{
    internal interface ICalc
    {
        double Result { get; set; }
        void Sum(int x);
        void Sub(int x);
        void Multiply(int x);
        void Divide(int x);
        event EventHandler<EventArgs> MyEventHandler;
        void CancelLast() { }
    }
}
