// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double[5];
int size = array.Length;
double dif = 0;
double min=array[0];
double max=array[0];

for(int i=0; i<size; i++)
{
    array[i]=new Random().Next(-99,100);
    
    if(array[i]>max)
    {
        max=array[i];
    }
    if(array[i]<min)
    {
        min=array[i];
    }

    dif = max - min;
}
Console.WriteLine(String.Join(";",array));
Console.WriteLine("Разница между max и min = "+dif);