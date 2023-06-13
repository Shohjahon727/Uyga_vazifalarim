//class Laptop
//{
//    //Fieldlar
//    string Name;
//    string BramdName;
//    DateTime ReleaseDate;
//    decimal Price;
//    ELaptopType Type;
//    //Propertylar
//    void Getter()
//    {
//        Console.WriteLine(Name);
//    }
//    void Setter( string name)
//    {
//        Name = name;
//    }
//}
//enum  ELaptopType
//{
//    Gaming,
//    Office,
//    Home,

//}
//----------------------------------------------------------------------------------------------------------------------


//namespace Shohjahon;
//public static class Program
//{
//    public static void Main()
//    {
//        //var calculator = new Calculator();
//        //Console.WriteLine(calculator.Qoshish(1,2,3)); 
//        var publicObject = new PublicClass();
//        publicObject.PublicField = 10;
//        publicObject.PublicMethod();

//        var privateObject = new PrivateClass();

//    }





//    private class PrivateClass
//    {
//        private int PrivateField;
//            private void PrivateMethod() { }
//    }
//}

//public class Calculator
//{
//    public int son;
//     public int Qoshish(params int[] sonlar)
//    {
//       if ( sonlar.Length == 0 ) throw new Exception("Kamida bitta sonni kiritishingiz kerak") ;
//        return sonlar.Sum();
//    }

//    public double Qoshish(params double[] sonlar)
//    {
//        if ( sonlar.Length == 0 ) throw new Exception("Kamida bitta sonni kiritishingiz kerak") ;
//        return sonlar.Sum();

//    }

//}

//public class PublicClass
//{
//    public int PublicField;
//    public void PublicMethod() { }
//}


public class Laptop
{
    public string Name { get; set; } = null!;
    public string BrandName { get; set; } = string.Empty;

    public DateOnly RelaseDate { get; set; }
    public decimal Price { get; set; }
    public ELaptopType Type { get; set; } = ELaptopType.Gaming;
     public double Weight { get; set; }
    public Ram Ram { get; set; }
    //private int BackingField;
    //public int BackingFieldProparty
    //{
    //    get
    //    {
    //        return BackingField;
    //    }
    //    set { BackingField = value; }
    //}
}

public enum ELaptopType
{
    Gaming,
    Office,
    Home,
}

public
public static class Program
{
    public static void Main()
    {

    }
}