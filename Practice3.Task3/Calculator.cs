namespace Practice3.Task3;

public class Calculator
{
    double number1 = 1;
    double Number1
    {
        get { return number1; }
        set { number1 = value; }
    }
    
    double number2 = 2;
    double Number2
    {
        get { return number2; }
        set { number2 = value; }
    }
    
    public void Addition(double number1, double number2)
    {
       double result = number1 + number2;
       Console.WriteLine($"Результат сложения {result}");
    }

    public void Subtraction(double number1, double number2)
    {
        double result = number1 - number2;
        Console.WriteLine($"Результат вычитания {result}");
    }

    public void Multiplication(double number1, double number2)
    {
        double result = number1 * number2;
        Console.WriteLine($"Результат умножения {result}");
    }

    public void Division(double number1, double number2)
    {
        if (number2 == 0)
            Console.WriteLine("Деление на 0 запрещено");
        else
        {
            double result = number1 / number2;
            Console.WriteLine($"Результат деления {result}");
        }
    }
}

