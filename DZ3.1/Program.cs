// Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(x); // Решение от преподавателя

//string num = Console.ReadLine(); // мое решение было

if(x>=10000 && x<=100000)
{
    if(num[0]==num[4] && num[1]==num[3])
    {
        Console.WriteLine(" - число является палиндромом");
    }
    else
    {
        Console.WriteLine(" - число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Число НЕ пятизначное");
}

// if (num.Length == 4)
// {
//     if(num[0]==num[4] && num[1]==num[3])
//     {
//         Console.WriteLine(" - число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine(" - число НЕ является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Это не пятизначное число");
// }