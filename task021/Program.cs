/*

Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
ddtcnbA (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.Clear();

int xa, ya, za, xb, yb, zb;

Console.Write($"Введите координаты точки А: ");

Console.WriteLine();

Console.Write("X= ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Y= ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Z= ");
int.TryParse(Console.ReadLine()!, out za);

Console.Write($"Введите координаты точки B: ");

Console.WriteLine();

Console.Write("X= ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Y= ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"Z= ");
int.TryParse(Console.ReadLine()!, out zb);

Console.WriteLine($"Координаты точки А: ( {xa}, {ya}, {za} )");
Console.WriteLine($"Координаты точки А: ( {xb}, {yb}, {zb} )");

int x = (xb-xa)*(xb-xa);
int y = (yb-ya)*(yb-ya);
int z = (zb-za)*(zb-za);

// Console.WriteLine($"Координаты точки XYZ: ( {x}, {y}, {z} )");

double ans = Math.Sqrt(x+y+z);

Console.WriteLine($"Расстояние между точками А и В:  {Math.Round(ans, 2)} ");



