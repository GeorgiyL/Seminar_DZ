// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string NaturalNum (int m, int n)
{
    if(m<=n) return $"{m} "+ NaturalNum(m+1,n);
    else return string.Empty;
}
Console.WriteLine(NaturalNum(m,n));
