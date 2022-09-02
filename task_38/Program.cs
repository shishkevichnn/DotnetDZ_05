/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write("Введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine());

double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.NextDouble() * 100;
        }
    return array;
}

double DifferenceMaxMin(double[] result)
{
    double difference = 0;
    double max = result[0];
    double min = result[0];
    for (int i=0; i < result.Length; i++)
    {
        if (result[i] > max) max = result[i];
        if (result[i] < min) min = result[i];
        {
            difference = max - min;
        }
    }
    return difference;
}

double[] array = GetArray(N);
Console.WriteLine($"[{String.Join(" ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {DifferenceMaxMin(array)}");