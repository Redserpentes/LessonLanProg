/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();

int[] array = { 4, -3, 7 };

int index = 0;
int n = array.Length;

while (index < n)

{
    if(array[index] % 2 ==0)
    {
        Console.Write($"{array[index]} - четное");
        Console.WriteLine();
    }
    
    else
    {
        Console.WriteLine($"{array[index]} - нечетное");
    } 
index++;
}




