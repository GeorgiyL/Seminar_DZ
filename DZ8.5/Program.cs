// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] matrix=new int[4,4];
int count=0;
int i=0;
int j=0;

for (j=0; j<matrix.GetLength(1); j++)
{
    matrix[i,j]=1+count;
    count++;
}
j=3;
for(i=1; i<matrix.GetLength(0); i++)
{
    matrix[i,j]=1+count;
    count++;
}
i=3;
for (j=2; j>=0; j--)
{
    matrix[i,j]=1+count;
    count++;
}
j=0;
for (i=2; i>=1; i--)
{
    matrix[i,j]=1+count;
    count++;
}
i=1;
for(j=1; j<=2; j++)
{
    matrix[i,j]=1+count;
    count++;
}
i=2;
for(j=2; j>=1; j--)
{
    matrix[i,j]=1+count;
    count++;
}
for(i=0; i<matrix.GetLength(0); i++) // Заполнение и вывод полученного массива
{
    for(j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}