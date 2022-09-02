// Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.Write("Введите координату Х точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine("Расстояние между точками А и В: " + d);