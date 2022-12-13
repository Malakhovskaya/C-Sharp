/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] startArray = GetArray(6, 0, 10);//ввели одномерный массив StartArray через функцию(метод GetArray)
Console.WriteLine(String.Join(" ", startArray)); //выводим на консоль через пробел
Console.WriteLine($"Сумма элементов на нечетных позициях равна = {GetSumOddElements(startArray)}"); //выводим сумму элементов на нечетных позициях

int[] GetArray(int size, int minValue, int maxValue) //метод зеполнения массива рандомными числами (размер, мин и макс числа)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetSumOddElements(int[] array) //ввели метод, вычисляющий сумму чисел на нечетных индексах в массиве
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i++) //циклом for перебираем все индексы от 0 до длины массива
    {
        
        if (i % 2 == 1) //если индекс нечетный, то число этого индекса суммируется
        sum = sum + array[i];
        
    }
    return sum;
}

