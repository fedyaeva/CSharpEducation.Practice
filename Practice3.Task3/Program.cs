namespace Practice3.Task3;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine("Введите число 1");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 2");
        double number2 = double.Parse(Console.ReadLine());
        calculator.Addition(number1, number2);
        calculator.Subtraction(number1, number2);
        calculator.Division(number1, number2);
        calculator.Multiplication(number1, number2);
    }
}