namespace Practice5.Task1;

public class Employee
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
    
    public virtual double CalculateBonus()
    {
        double bonus = salary * 0.1;
        return bonus;
    }
}