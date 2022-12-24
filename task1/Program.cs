//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите чиcло");
string num = (Console.ReadLine() ?? "");
int n = num.Length;
if (n<3)
{
    Console.WriteLine($"Третей цифры нет");
}
else    
{
    int a = int.Parse(num);
    int c = 1;
    for (int i = n; i>3; i--)
        {
            c=c*10;
        }
    int b = (a/c)%10;
    Console.WriteLine($"Третья цифра числа {a} = {b}");
}
