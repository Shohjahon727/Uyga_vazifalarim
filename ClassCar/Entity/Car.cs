using Car.Entity.Enum;
using System;
namespace Car.Entity;
public class Car	
{
	public CarType Name { get; set; }
	public ColorType Color { get; set; }
	public DateTime YearOfManifucture { get; set; }
	public decimal Price { get; set; }
	public int Power { get; set; }

    public Car() {} 
    public Car(CarType name,ColorType color, DateTime year,decimal price,int power)
    {
        Name = name;
        Color = color;
        YearOfManifucture = year;
        Price = price;
        Power = power;
    }
    public Car(CarType name , DateTime year , decimal price)
    {
        Name =name;
        YearOfManifucture = year;
        Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name : {Name}\n" +
            $"YearOfManifacture : {YearOfManifucture}\n" +
            $"Price : {Price} $\n" +
            $"Color :  {Color}\n" +
            $"Power : {Power} W\n");
    }


}


