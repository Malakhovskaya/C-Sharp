/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Write("Задайте прямоугольный двумерный массив (необходимо ввести любое число от 1): ");
int rowsColums=int.Parse(Console.ReadLine());  

int[,] array = GetArray(rowsColums, rowsColums, 0, 10); 

PrintArray(array); // выводим заполненный рандомный массив в терминале



int[,] GetArray(int m, int n, int min, int max) //метод заполнения массива рандомными числами
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray) //метод вывода в терминал получившегося массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int minSum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minSum)
    {
        minSum = sum;
        indexLine++;
    }
}

Console.WriteLine();
Console.WriteLine("Наименьшая сумма элементов равняется " + (minSum) + ", в строке под номером " + (indexLine));
