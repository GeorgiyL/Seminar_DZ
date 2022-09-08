// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(0,1000); // до значения 999
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

FillArray(array);
PrintArray(array);
