// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите M чисел: ");
int num=Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];
int positiv = 0;

for(int i=0; i<num; i++)
{
    array[i]= Convert.ToInt32(Console.ReadLine());
    if(array[i]>0)
    {
        positiv+=1;
    }
    Console.WriteLine("[{0}]", string.Join(",",array));

}
Console.WriteLine("Кол-во чисел больше нуля: "+positiv);