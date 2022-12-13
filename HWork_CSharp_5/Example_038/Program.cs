/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 */

int[] startArray = GetArray(6, 0, 20);
Console.WriteLine(String.Join(" ", startArray)); 
Console.WriteLine($"Разница между максимальным и минимальным элементом = {GetDifference(startArray)}");

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetDifference(int[] array) //ввели метод, вычисляющий разницу максимального и минимального элементов
{
    int min = array [0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}


