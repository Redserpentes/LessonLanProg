/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();

int n;

Console.Write($"Введите число N: ");

Console.WriteLine();

Console.Write("N= ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"Квадрат чисел от 1 до {n}: ");


for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)}, ");


