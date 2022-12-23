//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
string numberA = Console.ReadLine();
int a = int.Parse(numberA);
Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine();
int b = int.Parse(numberB);
Console.WriteLine("Введите третье число");
string numberC = Console.ReadLine();
int c = int.Parse(numberC);
int max = 0;
if (a>b) 
{
    max = a;
}
else
{
    max = b;
};
if (c>max)
{
    max=c;
}
Console.WriteLine($"Максимальное число {max}");
