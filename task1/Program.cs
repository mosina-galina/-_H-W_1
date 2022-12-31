//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату x первой точки");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату y первой точки");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату z первой точки");
int z1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату x второй точки");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату y второй точки");
int y2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите координату z второй точки");
int z2 = int.Parse(Console.ReadLine() ?? "");
int a = x2-x1;
int b = y2-y1;
int c = z2-z1;
double len = Math.Sqrt(a*a+b*b+c*c);
Console.WriteLine($"Растояние между точками равно {len}");
