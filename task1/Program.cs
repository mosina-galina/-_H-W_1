//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число ");
string num = (Console.ReadLine() ?? "");
int len = num.Length;
int n = int.Parse(num);
void sum(int n, int len)
{
    int plus = 0;
    for (int i = 0; i < len; i++)
    {
        plus = plus + n%10;
        n = n/10;
    }
    Console.WriteLine($"Сумма цифр в числе {num} = {plus}");
}
sum(n,len);

