// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [rows,columns];

for(int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        matrix[i, j] = new Random().NextDouble()*10;
        Console.Write(Math.Round(matrix[i,j],1)+"\t");
    }
    Console.WriteLine();
}