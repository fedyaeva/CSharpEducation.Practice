namespace Practice3.Task5;

public class Book
{
    string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    string author;
    
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    int yearOfPublication;

    public int YearOfPublication
    {
        get { return yearOfPublication; }
        set {yearOfPublication = value;}
    }
    
    public Book() : this ("Без названия", "Неизвестный автор", 1899)
    {
    }

    public Book(string name) : this(name, "Неизвестный автор", 1899)
    {
        
    }
    
    public Book(string name, string author) : this(name, author, 1899)
    {
        
    }
    public Book(string name,  string author, int yearOfPublication)
    {
        this.name = name;
        this.author = author;
        this.yearOfPublication = yearOfPublication;
    }
}