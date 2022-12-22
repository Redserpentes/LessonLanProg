/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Clear();

int a1 = 4;
int b1 = 7;
int a2 = 2;
int b2 = 10;
int a3 = -9;
int b3 = -3;

int max1 = b1;
int max2 = b2;
int max3 = b3;

if (a1 > b1) max1 = a1;
if (a2 > b2) max2 = a2;
if (a3 > b3) max3 = a3;

Console.WriteLine (max1);
Console.WriteLine (max2);
Console.WriteLine (max3);
