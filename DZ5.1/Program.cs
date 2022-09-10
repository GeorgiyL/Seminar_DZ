// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[4];
int size = array.Length;
int sum = 0;

for(int i=0; i<size; i++)
{
    array[i]=new Random().Next(100,1000);
    int num=array[i]%2;
    if(num==0)
    {
        sum+=array[i];
    }
}
Console.WriteLine(String.Join(";",array));
Console.WriteLine("Сумма четных чисел = "+sum);