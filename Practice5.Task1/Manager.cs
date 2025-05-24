namespace Practice5.Task1;

public class Manager : Employee
{
    private int teamSize;

    public int TeamSize
    {
        get { return teamSize; }
        set { teamSize = value; }
    }
    public Manager(string name, double salary, int teamSize) : base(name, salary)
    {
        this.teamSize = teamSize;
    }
    
    public override double CalculateBonus()
    {
        double bonus;
        if (teamSize > 5)
        {
            bonus = Salary * (0.2 + 0.05);
        } else bonus = Salary * 0.2;
        return bonus;
    }
    
}