//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите длинну массива ");
int n = int.Parse(Console.ReadLine() ?? "");
double[] array = new double[n];
for (int i = 0; i < n; i++)
{  
    array[i] = new Random().Next(1,1000);
    Console.Write($"{array[i]} ");
}
double max = array[0];
double min = array[0];
for (int k = 0; k < n; k++)
{
        if (array[k] > max) max = array[k];
        else
        {
            if (array[k] < min) min = array [k];
        }
}
Console.WriteLine($" максимальное - {max}, минимальное - {min}");
double p= max-min;
Console.WriteLine($"разница между максимальным и минимальным = {p}");