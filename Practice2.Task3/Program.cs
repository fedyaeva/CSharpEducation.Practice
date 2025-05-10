namespace Practice2.Task3;

class Program
{
    static void Main(string[] args)
    {
        //Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a + b). Все переменные задаются пользователем. Учтите деление на
        double a, b, f;
        while (true)
        {
            Console.WriteLine("Укажите значение a");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                break;
            }

            Console.WriteLine("Необходимо ввести число, повторите ввод еще раз");
        }

        while (true)
        {
            Console.WriteLine("Укажите значение b");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                break;
            }

            Console.WriteLine("Необходимо ввести число, повторите ввод еще раз");
        }

        while (true)
        {
            Console.WriteLine("Укажите значение f");
            if (double.TryParse(Console.ReadLine(), out f))
            {
                break;
            }

            Console.WriteLine("Необходимо ввести число, повторите ввод еще раз");
        }

        if (a == 0)
        {
            Console.WriteLine("Невозможно выполнить вычисление, т.к. деление на 0 запрещено");
        }
        else
        {
            double result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine(result);
        }
    }
}