namespace Practice4.Task4;

public class Book
{
    string name;

    public string Name
    {
        get { return name; }
    }
    
    string author;
    
    public string Author
    {
        get { return author; }
    }
    
    public Book(string name, string author)
    {
        this.name = name;
        this.author = author;
    }

    public Book()
    {
        this.name = "Без названия";
        this.author = "Неизвестный автор";
    }
}