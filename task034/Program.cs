/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();

Console.WriteLine("Задайте вилечину массива: ");
int n = Convert.ToInt32( Console.ReadLine());

int[] array = new int[n];
Console.Write($"Массив из {n} элементо: ");
int j=0;

for (int i =0; i < n; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write($"{array[i]}|");
         if ((array[i]) % 2 == 0)
    {
        j++;
    }

}

Console.WriteLine();
Console.WriteLine($"Четных чисел в данном массиве: {j} ");
