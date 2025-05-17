namespace Practice3.Task6;

public struct Point
{
    private int x;

    public int X
    {
        get { return x; }
        set { x = value; }
    }
    
    private int y;

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public Point() : this (0, 0)
    {
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    } 
    
    public double calculateDistance(Point point1, Point point2)
    {
        double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        return distance;
    }
}