// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Введите кол-во строк Х: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов Y: ");
int columns=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива по Z: ");
int z=Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (rows*columns*z>90) // Проверка условия достаточности двузначных чисел
{
    Console.WriteLine("Недостаточно уникальных двузначных чисел");
}
else
{
    int count=0;
    int[] array = new int[90];
    for(int i=0; i<array.Length-1; i++) // Вспомогательный массив из двузначных элементов по порядку
    {
        array[i]=10+i;
    }
    for (int i=0; i<array.Length; i++) // Перестановка значений внутри массива
    {
        int j=new Random().Next(array.Length);
        int temp = array[j];
        array[j]=array[i];
        array[i]=temp;
    }

    int[,,] matrix=new int[rows, columns, z]; // Задаем трехмерный массив

    for (int i=0; i<matrix.GetLength(0); i++) // Заполняем массив
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            for (int k=0; k<matrix.GetLength(2); k++)
            {
                matrix[i,j,k]=array[count];
                Console.Write($"{matrix[i,j,k]}({i},{j},{k})"+"\t");
                count+=1;
            }
            Console.WriteLine();
        }
    }
}