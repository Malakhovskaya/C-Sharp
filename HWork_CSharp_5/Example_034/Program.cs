/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2*/

int[] startArray = GetArray(6, 100, 999);//ввели трехзначный положит. массив StartArray через функцию(метод GetArray)
Console.WriteLine(String.Join(" ", startArray)); 
Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}"); //выводим кол-во четных элементов

int[] GetArray(int size, int minValue, int maxValue) //метод зеполнения массива рандомными числами (размер, мин и макс числа)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetEvenCount(int[] array) //ввели метод, вычисляющий кол-во четных чисел в массиве
{
    int count = 0;
    foreach (var item in array) //циклом foreach перебираем все числа (var item) в массиве array 
    {
        if (item % 2 == 0) count++; // если число четное (делится на 2 без остатка), то счетчик +1
    }
    return count;
}

