// Напишите программу, которая на вход принимает число (N), а на
// выходе показывает все чётные числа от 1 до N.

//Читерское решение этой задачи =)
// Console.Write("Введите число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// int number = 2;

// while(number > 1 && number <= numberN)
// {
//     Console.Write(number + "; ");
//     number = number + 2;
// }

// Универсальное решение
Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int number = 2;

while(number > 1 && number <= numberN)
{
    int rem = number % 2;

    if(rem == 0)
    {
        Console.Write(number + "; ");
    }
    
    number++;
}