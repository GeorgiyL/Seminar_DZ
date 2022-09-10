// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[4];
int size = array.Length;
int sum = 0;

for(int i=0; i<size; i++)
{
    array[i]=new Random().Next(-99,100);
    int num=i%2;
    if(num==0)
    {
        sum=sum;
    }
    else
    {
        sum+=array[i];
    }
}
Console.WriteLine(String.Join(";",array));
Console.WriteLine("Сумма нечетных элементов = "+sum);