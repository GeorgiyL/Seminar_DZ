// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(x);

int sum = 0;
int count = 0;
int size = num.Length;

while(size>count)
{
    sum =sum + (int) char.GetNumericValue(num[count]); // Метод из семинара 5
    count++;
}

Console.WriteLine("Сумма цифр = "+sum);



// int GetSum(string number) // Пробовал делать так, сумму выдает не верно
// {
//     int sum = 0;
//     int count = 0;
//     int size = number.Length;
//     while(size>count)
//     {
//         sum+=number[count];
//         count++;
//     }
//     return sum;
// }