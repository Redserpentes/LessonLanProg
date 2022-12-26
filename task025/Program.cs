/*
Задача 25:

 Напишите цикл, который принимает на вход два числа (A и B
) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

int [] array = new int[2];
// int n;

for (int i = 0; i < array.Length; i++)
{
   Console.Write($"Введите число {i+1}: ");
   int.TryParse(Console.ReadLine()!, out array[i]);
}
Console.WriteLine();

Console.Write($"Возведение числа {array[0]} в степень {array[1]} =  {Math.Pow(array[0], array[1])}");
