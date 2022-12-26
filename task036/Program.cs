/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

Console.WriteLine("Задайте велечину массива: ");
int n = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Задайте максимальное число массива: ");
int m = Convert.ToInt32( Console.ReadLine());

int[] array = new int[n];
Console.Write($"Массив из {n} элементо: ");
int j=0;

for (int i =0; i < n; i++)
{
    array[i] = new Random().Next(0, m);
    Console.Write($"{array[i]}|");
         if (i % 2 == 0)
    {
        j += array[i];
    }

}

Console.WriteLine();
Console.WriteLine($"Сумма чисел на четных позициях данного массиве: {j} ");