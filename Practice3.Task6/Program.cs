namespace Practice3.Task6;

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(-7,-4);
        Point point2 = new Point(5,6);
        Console.WriteLine(point2.calculateDistance(point1, point2));
    }
}