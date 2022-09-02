// Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();

if(num[0]==num[4] && num[1]==num[3])
{
    Console.WriteLine(" - число является палиндромом");
}
else
{
    Console.WriteLine(" - число НЕ является палиндромом");
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