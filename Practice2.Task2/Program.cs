namespace Practice2.Task2;

class Program
{
    static void Main(string[] args)
    {
        //a. метры в километры
        Console.WriteLine("Задание 2a");
        double meter = 5000;
        double kilometer = meter / 1000;
        Console.WriteLine($"{meter} метров = {kilometer} километров");
        
        //b. километры в сантиметры
        Console.WriteLine("Задание 2b");
        double centimeter = kilometer * 100000;
        Console.WriteLine($"{kilometer} километров = {centimeter} сантиметров");
        
        //c. м/с в км/ч
        Console.WriteLine("Задание 2c");
        double speedMeterPerSec = 1234;
        double speedKilometerPerHour = speedMeterPerSec * 3.6;
        Console.WriteLine($"{speedMeterPerSec} м/с = {Math.Round(speedKilometerPerHour, 2)} км/ч");
        
        //d. градусы C в градусы F
        Console.WriteLine("Задание 2d");
        double temperatureС = -23;
        double temperatureF = temperatureС * 1.8 + 32;
        Console.WriteLine($"{temperatureС} С = {Math.Round(temperatureF, 2)} F");
    }
}