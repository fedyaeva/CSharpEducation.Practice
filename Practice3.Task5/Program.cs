namespace Practice3.Task5;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Книга о чем-то");
        Console.WriteLine(book.Name);
        Console.WriteLine(book.Author);
        Console.WriteLine(book.YearOfPublication);
    }
}