/*
Console.WriteLine("1-example");
for(int i=1;i<=10;i++)
{
    Console.Write($" {i} ");
}
*/
/*
Console.WriteLine("2-example");
int sum = 0;
for(int i=1;i<=10;i++)
{
    sum = sum+i;
}
Console.WriteLine(sum);
*/
/*
Console.WriteLine("3-example");
int n;
int sum = 0;
int .TryParse(Console.ReadLine(), out n);
for (int i=1;i<=n;i++)
{
    sum = sum + i;
    Console.Write($"{i} ");

}
Console.Write("Sum=");
Console.WriteLine(sum);
*/
/*
Console.WriteLine("4-example");
double n;
double.TryParse(Console.ReadLine(), out n);
double sum = 0;
for (int i=1;i<=n;i++)
{
    sum = sum + i;
}
Console.Write("Sum = ");
Console.WriteLine(sum);
double averages = sum / n;
Console.Write("Averges = ");
Console.WriteLine(averages);
*/
/*
Console.WriteLine("5-exalmple");
int n;
int .TryParse(Console.ReadLine(), out n);
for (int i=1;i<=n;i++)
{
    Console.WriteLine( Math.Pow(i, 3));
}
*/
/*
Console.WriteLine("6-example");
int n;
int .TryParse(Console.ReadLine(), out n);   
for(int i=1;i<=n;i++)
{
    Console.WriteLine($" {n} * {i} = {n*i} ");
}
*/
/*
Console.WriteLine("7-example");
Console.WriteLine("Karralar jadvalini chiqarish uchun boshlang'ich sonni kiriting:");
int boshlangichSon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Karralar jadvalini chiqarish uchun oxirgi sonni kiriting:");
int oxirgiSon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Karralar jadvali:");
for (int i = boshlangichSon; i <= oxirgiSon; i++)
{
    for (int j=boshlangichSon;j<=10;j++)
    {
        Console.WriteLine($" {i} * {j} = {i * j} ");
    }
    Console.WriteLine();
}
*/
/*
Console.WriteLine("8-example");
int n;
int .TryParse(Console.ReadLine(), out n);
int sum = 0;
for(int i=1;i<=n;i++)
{
   if(i%2==1)
    {
        sum=sum+i;
        Console.Write($" {i} ");
    }
}
Console.WriteLine("\n");
Console.Write("Sum = ");
Console.WriteLine(sum);
*/
/*
Console.WriteLine("9-example");
int n;
int .TryParse(Console.ReadLine(), out n);
for (int i=0;i<n;i++)
{
    for(int j=0;j<n;j++)
    {
        if(j<=i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
*/
/*
Console.WriteLine("10-example");
int n;
int .TryParse(Console.ReadLine(), out n);
for(int i=1;i<=n;i++)
{
    for(int j=1;j<=i;j++)
    {
         Console.Write(j);
      
    }
    Console.WriteLine();
}
*/
/*
Console.WriteLine("11-example");
int n;
int.TryParse(Console.ReadLine(), out n);
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);

    }
    Console.WriteLine();
}
*/
/*
Console.WriteLine("12-example");
int n;
int.TryParse(Console.ReadLine(), out n);
int k = 1;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(k++);

    }
    Console.WriteLine();
}
*/
/*
Console.WriteLine("Input number of terms: ");
int n;
int .TryParse(Console.ReadLine(), out n);
int sum = 0;
for (int i=1; i<=n; i++)
{
   int m = 2 * i;
   Console.WriteLine(m+" ");
   sum+=m;
}
Console.WriteLine($" {n} sum = {sum} " );
*/
/*
Console.WriteLine("Faftorial");
int n;
int.TryParse(Console.ReadLine(), out n);
int kop = 1;
for (int i=1;i<=n;i++)
{
    kop=kop*i;
}
Console.WriteLine($"faktorial = {kop}");
*/
/*
Console.WriteLine("Yigindi:");
double n;
double.TryParse(Console.ReadLine(), out n);
double sum = 0;
for (int i = 1; i <= n;i++)
{
    double m = 1 / i; sum+=m;
}
Console.WriteLine($" sum = {sum} ");
*/