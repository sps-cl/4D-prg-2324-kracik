namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorContext context = new CalculatorContext(new OperatonAdd());

            Console.WriteLine($"4 + 5 = " + context.executeOperation(4,5));
        }
    }
}