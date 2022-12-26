/*
Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/
Console.Clear();

int[] array = new int[8];
Console.Write("Массив из восьми элементо: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(8);
    Console.Write($"{array[i]}|");
}
