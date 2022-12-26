/*
Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.Clear();

Console.WriteLine("Задайте велечину массива: ");
int n = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Задайте минимальное число массива: ");
int mm = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Задайте максимальное число массива: ");
int m = Convert.ToInt32( Console.ReadLine());

double[] array = new double[n];
Console.Write($"Массив из {n} элементо: ");
   
    Random r = new Random();
        for (int i =0; i < n; i++)
    {
        array[i] = r.Next(mm, m) + Math.Round(r.NextDouble(), 2);
        Console.Write($"{array[i]}|");
    }
double min = array.Min();
double max = array.Max();
double result = Math.Round((max - min), 2);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент масива= {max}");
Console.WriteLine($"Минимальный элемент масива= {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");