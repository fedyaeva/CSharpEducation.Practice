namespace Practice3.Task2;

public class Student
{
    string name = "Саша";
    int age = 32;
    double averageScore;

    public double AverageScore
    {
        get { return averageScore; }
        set
        {
            if (value is < 0 or > 5)
                Console.WriteLine("Средний балл должен быть в диапазоне от 0 до 5");
            else 
                averageScore = value;
        }
    }

public void InfoAboutStudent() {
        Console.WriteLine($"Имя студента: {name}, возраст студента: {age}, средний балл: {averageScore}"); 
    }
    
}