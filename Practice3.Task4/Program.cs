namespace Practice4.Task4;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Название книги","Саша");
        Console.WriteLine(book.Name);
        Console.WriteLine(book.Author);
    }
}