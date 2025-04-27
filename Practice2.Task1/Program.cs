namespace Practice2.Task1;

class Program
{
    static void Main(string[] args)
    {
        
        //a. цикл for. Пусть он выводит в консоль значение своего же счётчика
        Console.WriteLine("Задание 1a");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("for  " + i);
        }

        //b. цикл while. Пусть он выводит в консоль значение своего же счётчика
        Console.WriteLine("Задание 1b");
        int b = 0;
        while(b < 10)
        {
            Console.WriteLine("while  " + b);
            b++;
        }
        
        
        //c. цикл do while. Пусть он выводит в консоль значение своего же счётчика.
        Console.WriteLine("Задание 1c");
        int c = 0;
        do
        {
        Console.WriteLine("do while " + c);
        c++;
        } while (c < 10);

        //d. цикл for, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами
        Console.WriteLine("Задание 1d");
        string[] text1 = new string[4];
        for (int d = 0; d < 4; d++)
        {
            Console.WriteLine($"Введите слово № {d + 1}: ");
            text1[d] = Console.ReadLine();
        }
        String sentence1 = string.Join(" ", text1);;
        Console.WriteLine($"Фраза для цикла for: {sentence1}");
        
        //e. цикл while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.
        Console.WriteLine("Задание 1e");
        int e = 0;
        string[] text2 = new string[4];
        while (e < 4)
        {
            Console.WriteLine($"Введите слово № {e + 1}: ");
            text2[e] = Console.ReadLine();
            e++;
        }
        String sentence2 = string.Join(" ", text2);;
        Console.WriteLine($"Фраза для цикла while: {sentence2}");
        
        //f. цикл do while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами
        Console.WriteLine("Задание 1f");
        int f = 0;
        string[] text3 = new string[4];
        do
        {
            Console.WriteLine($"Введите слово № {f + 1}: ");
            text3[f] = Console.ReadLine();
            f++;
        } while (f < 4);
        String sentence3 = string.Join(" ", text3);;
        Console.WriteLine($"Фраза для цикла do while: {sentence3}");
    }
}