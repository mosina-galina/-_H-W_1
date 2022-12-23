//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите чиcло");
int N = int.Parse(Console.ReadLine() ?? "");
if (N>0) 
{
   int k=1;
    while (k<=N)
    {
        if(k%2==0)
        {
            Console.Write($"{k} ");
        }
        k++;
    }
}
else
{
   int k=1;
    while (k>=N)
    {
        if(k%2==0)
        {
            Console.Write($"{k} ");
        }
        k--;
    }
}

