//----------------Funksiyalar---------------
void Ekrangachiqar(string paramet)
{
    Console.WriteLine(paramet);
}

Ekrangachiqar("Salom");


void ArrayniToldir(int[] array )
{
    for(int i=0;i<array.Length; i++)
    {
        array[i] = i + 1;
    }
}
Ekrangachiqar("Salom");
var array = new int[10];
ArrayniToldir(array);

