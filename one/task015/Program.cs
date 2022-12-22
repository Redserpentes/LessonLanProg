/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("Введите число дня недели");
int n = Convert.ToInt32( Console.ReadLine());

if (n <=7 && n >=1)
{ 
    if (n < 6)

    {
      Console.WriteLine($"{n} - Будний день");
    }
    else
    {
      Console.WriteLine($"{n} - Выходной день");
    }
}

else
{
Console.WriteLine("Число введено неверно");
}
