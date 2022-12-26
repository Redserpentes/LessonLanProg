/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Clear();

Console.WriteLine("Введите любое пятизначное число");
string n = Console.ReadLine()!;
int i = n.Length;

if (i != 5)
{ 
    Console.WriteLine("Число введено неверно");
}
else
{

int a = Convert.ToInt32(n[0]);
int b = Convert.ToInt32(n[1]);
int a1 = Convert.ToInt32(n[4]);
int b1 = Convert.ToInt32(n[3]);



    if (a == a1 && b == b1)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}


