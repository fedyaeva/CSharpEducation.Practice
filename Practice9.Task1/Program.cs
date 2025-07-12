namespace Practice9.Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<int> numbers = new List<int>();

        foreach (string item in inputs)
        {
            if (int.TryParse(item, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Число не было обноружено");
            }
        }
        List<Task> tasks = new List<Task>();

        foreach (int number in numbers)
        {
            Number num = new Number(number);
            Task task = Task.Run(() => num.Print());
            tasks.Add(task); 
        }
        
        Task.WaitAll(tasks.ToArray());
    }
}