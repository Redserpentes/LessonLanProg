/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.Write($"Введите число :  ");
string n = Console.ReadLine()!;

int[] array = new int[n.Length];
int sum = 0;
for (int i = 0; i < n.Length; i++)
    array[i] = int.Parse(n[i].ToString());
 
  int j;
  for (j=0; j <n.Length; j++)
    {
    sum += array[j];
   // Console.WriteLine(array[j]);
    }
  Console.WriteLine($"Сумма чисел в числе {n} = {sum}");
 