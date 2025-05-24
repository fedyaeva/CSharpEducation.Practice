namespace Practice5.Task1;

public class Contractor : Employee
{
    private double hourlyRate;

    public double HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }
    public Contractor(string name, double salary, double hourlyRate) : base(name, salary)
    {
        this.hourlyRate = hourlyRate;
    }

    public new double CalculateBonus(int hoursWorked)
    {
        double bonus = hoursWorked * hourlyRate * 0.1;
        return bonus;
    }
    
}