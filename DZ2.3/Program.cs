// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(1 <= num && num <= 7)
{
    if(1 <= num && num <= 5)
    {
        Console.WriteLine("Этот день НЕ выходной");
    }
    if(6 <= num && num <= 7)
    {
        Console.WriteLine("Этот день выходной!");
    }
}
else
{
    Console.WriteLine("Это не день недели");
}