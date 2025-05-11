namespace Practice2.Task4;

class Program
{
    static void Main(string[] args)
    {
        /*
         *4. Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту
     треугольника можно было задавать программно. Пример:
     a. *
     **
     ***
     ****
     и тд
     b. *
     **
     ***
     ****
     и тд
     c. Дайте возможность задавать символ для отрисовки программно. Т.е.
     вместо звёздочки может быть любой символ.
         *
         *
         */
        int height1;
        Console.WriteLine("Укажите значение высоты треугольника");
        while (!int.TryParse(Console.ReadLine(), out height1) || height1 <= 0)
        {
            Console.WriteLine("Необходимо ввести целое число, повторите ввод еще раз");
        }
        string[] triangle1 = new string[height1];
        for (int i = 0; i < height1; i++)
        {
            triangle1[i] = new string('*', i + 1);
        }
        for (int i = 0; i < height1; i++)
        {
            Console.WriteLine(triangle1[i]);
        }
        
        int height2;
        Console.WriteLine("Укажите значение высоты треугольника");
        while (!int.TryParse(Console.ReadLine(), out height2) || height2 <= 0)
        {
            Console.WriteLine("Необходимо ввести целое число, повторите ввод еще раз");
        }
        string[] triangle2 = new string[height2];
        for (int i = 0; i < height2; i++)
        {
            string spaces = new string(' ', height2 - i - 1);
            string stars = new string('*', i + 1);
            triangle2[i] = spaces + stars;
        }
        for (int i = 0; i < height2; i++)
        {
            Console.WriteLine(triangle2[i]);
        }
        
        int height3;
        Console.WriteLine("Укажите значение высоты треугольника");
        while (!int.TryParse(Console.ReadLine(), out height3) || height3 <= 0)
        {
            Console.WriteLine("Необходимо ввести целое число, повторите ввод еще раз");
        }
        char symbol;
        Console.WriteLine("Укажите символ для отрисовки треугольника");
        while (!char.TryParse(Console.ReadLine(), out symbol))
        {
            Console.WriteLine("Необходимо ввести один символ, повторите ввод еще раз");
        }
        string[] triangle3 = new string[height3];
        for (int i = 0; i < height3; i++)
        {
            triangle3[i] = new string(symbol, i + 1);
        }
        for (int i = 0; i < height3; i++)
        {
            Console.WriteLine(triangle3[i]);
        }
    }
}