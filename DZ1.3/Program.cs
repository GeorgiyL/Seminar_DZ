// Задача 6: Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным (делится ли оно на два без
// остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int rem = number % 2;

if(rem == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число нечетное");
}