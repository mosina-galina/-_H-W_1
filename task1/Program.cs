//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int len = 8;
int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    array[i] = new Random().Next(1,9);
    Console.Write($"{array[i]} ");
}
