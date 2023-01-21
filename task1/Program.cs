//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длинну массива ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
     array[i] = new Random().Next(1,1000);
    Console.Write($"{array[i]} ");
}
int p = 0;
for (int k = 0; k < n; k++)
{
     if (k%2! == 0) p=p+array[k];
}
Console.Write($" сумма - {p}");