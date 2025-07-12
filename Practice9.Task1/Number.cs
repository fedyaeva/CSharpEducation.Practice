namespace Practice9.Task1;
/// <summary>
/// Число
/// </summary>
public class Number
{
    private int number;

    public Number(int number)
    {
        this.number = number;
    }

    /// <summary>
    /// Вывод числа в консоль
    /// </summary>
    public void Print()
    {
        Console.WriteLine(number);
    }
    
}

