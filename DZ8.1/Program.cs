// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows,columns];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Упорядоченный массив:");

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        for(int k=0; k<matrix.GetLength(1)-1; k++)
        {
            if(matrix[i,k]<matrix[i,k+1])
            {
                int temp=matrix[i,k];
                matrix[i,k]=matrix[i,k+1];
                matrix[i,k+1]=temp;
            }
        }
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
