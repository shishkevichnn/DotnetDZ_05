/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Write("Введите количество элементов в массиве : ");
int size = int.Parse(Console.ReadLine());
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
        for (int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(minValue, maxValue+1);
        }
    return res;
}

int CountNumChet(int[] mas)
{
    int count = 0;
    for (int i=0; i < mas.Length; i++)
    {
        if (mas[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(size,100,1000);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов: {CountNumChet(array)}");
