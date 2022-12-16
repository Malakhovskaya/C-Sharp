/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите количество строк массива от 1: ");
int rows=int.Parse(Console.ReadLine());  

Console.Write("Введите количество столбцов массива от 1: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array); // выводим заполненный массив в терминале

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[i,j]<array[i,j+1])
            {
                int number = 0;
                number = array[i,j];
                array[i,j]=array[i,j+1];
                array[i,j+1] = number;
            }   
        }
    }
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив со значениями в строках от большего к меньшему");
PrintSortArray(array);


void PrintSortArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}