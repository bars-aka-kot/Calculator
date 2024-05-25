namespace Calculator
{
    public class MyDoubleTryParser
    {
        public int TryParse(string input)
        {
            try
            {
                int result = int.Parse(input);
                if (result >= 0)
                {
                    return result;
                }
                else
                {
                    throw new CalculatorExeption("Число отрицательное");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
