/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Write("Введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел от: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел до: ");
int b = int.Parse(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(minValue, maxValue+1);
        }
    return array;
}

int SumNumNechet(int[] result)
{
    int sum = 0;
    for (int i=0; i < result.Length; i++)
    {
        if (i %2 == 1)
        {
            sum = sum + result[i];
        }
    }
    return sum;
}

int[] array = GetArray(N, a, b);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях.: {SumNumNechet(array)}");
