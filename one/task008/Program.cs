/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();

Console.WriteLine("Введите любое число");
int n = Convert.ToInt32( Console.ReadLine());

int i = 1;

Console.Write("Четные числа до ");
Console.Write(n);
Console.WriteLine();
Console.WriteLine();

while (i < n)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
    i++;
}





