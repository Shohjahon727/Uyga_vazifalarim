
using Car.Entity.Enum;
namespace Car.Entity;
public class ClassCar
{
    public static void Main(string[] args)
    {
        //var Mashina = new Car();
        //Mashina.Name = CarType.BMW;
        //Mashina.YearOfManifucture = DateTime.Now;
        //Mashina.Price = 100000; 
        //Mashina.Color = ColorType.Black;
        //Mashina.Power = 500;
        //Mashina.PrintInfo();
        //Console.ReadKey();
        var Mashina = new Car(CarType.BMW, ColorType.Black, DateTime.Now, 100000, 500);
        Mashina.PrintInfo();
        Console.ReadKey();
    }

    
}
