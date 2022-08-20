// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("max = " + numberA);
    Console.WriteLine("min = " + numberB);
}
else
{
    Console.WriteLine("max = " + numberB);
    Console.WriteLine("min = " + numberA);
}