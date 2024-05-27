namespace Calculator
{
    internal class Terminal
    {
        Calc calc = new Calc();
        private double numInput()
        {
            Console.Write("Введите число: ");
            try
            {
                return new MyDoubleTryParser().TryParse(Console.ReadLine());
            }
            catch
            {
                return numInput();
            }
        }
        private void operationInput(double inputNum)
        {
            Console.WriteLine("Выберите действие: \n" +
                   "+ : Слоение\n" +
                   "- : Вычитание\n" +
                   "* : Умножение\n" +
                   "/ : Деление\n" +
                   "< : Отмена действия\n");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "+":
                    calc.Sum(inputNum);
                    break;
                case "-":
                    calc.Sub(inputNum);
                    break;
                case "*":
                    calc.Multiply(inputNum);
                    break;
                case "/":
                    try
                    {
                        calc.Divide(inputNum);
                    }
                    catch (CalculatorDivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    { Console.WriteLine(ex.Message); }
                    break;
                case "<":
                    calc.CancelLast();
                    break;
                default:
                    Console.WriteLine("Некорректный ввод операции");
                    operationInput(inputNum);
                    break;
            }
        }
        private static void Calc_MyEventHandler(object? sender, EventArgs s)
        {
            if (sender is Calc)
                Console.WriteLine(((Calc)sender).Result);
        }
        public void Start()
        {
            //Доработайте класс калькулятора способным работать как с целочисленными так и с дробными числами.
            //(возможно стоит задействовать перегрузку операций).

            calc.MyEventHandler += Calc_MyEventHandler;
            double inputNum = numInput();
            calc.Sum(inputNum);
            while (true)
            {
                inputNum = numInput();
                operationInput(inputNum);
            }
        }
    }
}
