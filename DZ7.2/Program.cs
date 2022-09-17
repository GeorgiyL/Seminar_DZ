// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

Console.Write("Введите номер строки: ");
int numbRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numbColumns = Convert.ToInt32(Console.ReadLine());

if(rows<numbRows || columns<numbColumns)
{
    Console.WriteLine("Такого элемента нет");
}
else
Console.WriteLine(matrix[numbRows-1, numbColumns-1]);
