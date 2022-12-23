//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое чило");
string numberA = Console.ReadLine();
int a = int.Parse(numberA);
Console.WriteLine("Введите второе чило");
string numberB = Console.ReadLine();
int b = int.Parse(numberB);
int max = 0;
int min = 0;
if (a>b) 
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Большее число {max}, а меньшее {min}");
