using System.Globalization;

namespace Practice8.Task1;

/// <summary>
/// Сортировка
/// </summary>
public class Sort
{
    /// <summary>
    /// Сортировка в зависимости от выбора пользователя
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="comparison"></param>
    public void SortNumber(List<int> numbers, Comparison<int> comparison)
    { 
        numbers.Sort(comparison);
    }

    /// <summary>
    /// Сортировка по возрастанию
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int SortIncrease(int a, int b)
    {
        return a.CompareTo(b);
    }

    /// <summary>
    /// Сортировка по убыванию
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int SortDecrease(int a, int b)
    {
        return a.CompareTo(a);
    }
    
}