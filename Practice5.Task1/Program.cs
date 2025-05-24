namespace Practice5.Task1;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Sasha", 100000);
        Manager manager = new Manager("Илья", 200000, 3);
        Contractor contractor = new Contractor("Дима", 100000, 200);
        Console.WriteLine($"Бонус сотрудника {employee.Name} с зарплатой {employee.Salary} равен {employee.CalculateBonus()}");
        Console.WriteLine($"Бонус сотрудника {manager.Name} с зарплатой {manager.Salary} и количеством человек в команде {manager.TeamSize} равен {manager.CalculateBonus()}");
        Console.WriteLine($"Бонус сотрудника {contractor.Name} с зарплатой {contractor.Salary} равен {contractor.CalculateBonus(160)}");
    }
}