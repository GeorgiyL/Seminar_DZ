// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows,columns];

for(int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        matrix[i, j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+"\t");
           
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int j=0; j<columns; j++)
{
    double sum = 0;
    double mid=0;
    for (int i=0; i<rows; i++)
    {
        sum+=matrix[i,j];
    }
    mid=sum/rows;
    Console.Write($"{Math.Round(mid, 2)}; ");
}