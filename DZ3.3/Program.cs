// Написать программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// int num = 1; // Первый способ через цикл
// while(num<=N)
// {
//     Console.Write(Math.Pow(num,3)+"; ");
//     num++;
// }

for (int num=1; num<=N; num++) // Второй способ через for
{
    Console.Write(Math.Pow(num,3)+"; ");
}