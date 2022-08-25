// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100, 1000);
int num1 =num/100;
int num2 = num1*100;
int num3 = num-num2;
int result = num3/10;

Console.WriteLine(num);
Console.WriteLine(result);
