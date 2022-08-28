// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if(100 < num && num <1000)
// {
//     int num1 = num%10;
//     Console.WriteLine(num1);
// }
// if(1000 < num && num <10000)
// {
//     int num1 = num%100;
//     int num2 = num1/10;
//     Console.WriteLine(num2);
// }
// if(10000 < num && num <100000)
// {
//     int num1 = num%1000;
//     int num2 = num1/100;
//     Console.WriteLine(num2);
// }

string str = Console.ReadLine(); // решение через символьный массив

if (str.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(str[2]); // выводить 3й символ
}