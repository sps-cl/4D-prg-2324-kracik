using System;

public interface IOperation
{
    int Execute(int x, int y);
}
public class OpAdd : IOperation
{
    public int Execute(int x, int y)
    {
        return x + y;
    }
}
public class OpSub : IOperation
{
    public int Execute(int x, int y)
    {
        return x - y;
    }
}
public class OpMagic : IOperation
{
    public int Execute(int x, int y)
    {
        return x * y;
    }
}
class CalculatorContext
{
    private IOperation operation;

    public CalculatorContext(IOperation operation)
    {
        this.operation = operation;
    }

    public int ExecuteOperation(int x, int y)
    {
        return operation.Execute(x, y);
    }
    public void SetOperation(IOperation operation)
    {
        this.operation = operation;
    }
}
class CalculatorApp
{
    static void Main(string[] args)
    {
        IOperation AddOperation = new OpAdd();
        IOperation SubOperation = new OpSub();
        IOperation MagicOperation = new OpMagic();

        CalculatorContext calculatorContext = new CalculatorContext(AddOperation);

        Console.WriteLine("Zadej číslo x (celá čísla): ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej číslo y (celá čísla): ");
        int y = int.Parse(Console.ReadLine());

        int result = calculatorContext.ExecuteOperation(x, y);

        Console.WriteLine("Výsledek sčítání je: " + result);

        calculatorContext.SetOperation(SubOperation);
        result = calculatorContext.ExecuteOperation(x, y);
        Console.WriteLine("Výsledek odčítání je: " + result);

        calculatorContext.SetOperation(MagicOperation);
        result = calculatorContext.ExecuteOperation(x, y);
        Console.WriteLine("Výsledek násobení je: " + result);
    }
}





