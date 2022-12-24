//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное чиcло");
string num = (Console.ReadLine() ?? "");
int n = num.Length;
if (n==3)
{
    int a = int.Parse(num);
    int b = a/10;
    b=b%10;
    Console.WriteLine($"Вторая цифра числа {a} = {b}");
}
else    
{
    Console.WriteLine($"Некорректный ввод");
}