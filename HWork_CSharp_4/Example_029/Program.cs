// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = GetRandomArray(8,0,10);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }

    return result;
}
