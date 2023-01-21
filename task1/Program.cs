//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите длинну массива ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]} ");
}
int p = 0;
for (int k = 0; k < n; k++)
{
    if (array[k]%2 == 0) p++;
}
Console.Write($"чётных - {p}");
