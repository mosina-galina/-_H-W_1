//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7 ");
int N = int.Parse(Console.ReadLine() ?? "");
if ((N>0)&&(N<8))
{
    if (N<6)
    {
        Console.WriteLine($"Не является выходным");
    }
    else
    {
        Console.WriteLine($"Выходной!");
    }
}
else
{
    Console.WriteLine($"Не является днем недели");

}
