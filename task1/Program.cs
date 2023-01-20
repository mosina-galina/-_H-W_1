//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine() ?? "");
void degree (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result =  result * a;
    
    }
    Console.WriteLine($"{A} в степени {B} = {result}");
}
degree(A,B);