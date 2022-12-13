/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] array = GetArray(5, 1, 99);  // вводим одномерный масив
Console.WriteLine(String.Join(" ", array)); // слепливанием и вывод массива на консоль


int [] GetArray(int size, int minValue, int maxValue) // вводим метод заполнения массива рандомными числами
{
   int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += 1;
    }


Console.WriteLine($"Пользователь ввёл {sum} положительных чисел");
