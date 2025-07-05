namespace Practice8.Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
        Sort sort = new Sort();

        List<int> numbers = new List<int>();
        foreach (var part in parts)
        {
            if (int.TryParse(part, out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine($"'{part}' не является числом, поэтому не будет учитываться при выводе");
            }
        }

        Console.WriteLine("Выберите порядок сортировки:");
        Console.WriteLine("1 - по возрастанию");
        Console.WriteLine("2 - по убыванию");
        string choice = Console.ReadLine();

        Comparison<int> comparison;
        switch (choice)
        {
          case "1":
              comparison = sort.SortIncrease;
              break;
          case "2":
              comparison = sort.SortDecrease;
              break;
          default:
              Console.WriteLine("Доступен выбор значения 1 и 2. Будет использована сортировка по возрастанию");
              comparison = sort.SortIncrease;
              break;
        }
        sort.SortNumber(numbers, comparison);
        
        Console.WriteLine("Список с сортировкой:");
        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
    }
}