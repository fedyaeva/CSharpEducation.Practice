namespace Practice2.Task5;

class Program
{
    static void Main(string[] args)
    {
        //Напишите программу для сравнения двух целых чисел. Ввод осуществляйте через консоль.
        int number1;
        int number2;
        Console.Write("Введите число 1: ");
        while (!int.TryParse(Console.ReadLine(), out number1))
        {
            Console.Write("Необходимо ввести число ");
        }
        Console.Write("Введите число 2: ");
        while (!int.TryParse(Console.ReadLine(), out number2))
        {
            Console.Write("Необходимо ввести число");
        }

        if (number1 == number2)
        {
            Console.WriteLine("Числа равны");
        } else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго");
        } else if (number1 < number2)
        {
            Console.WriteLine("Первое число меньше второго");
        }
    }
}