/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int n = 4; // ввели переменную, равную row and column так как по заданию массив 4х4 
int[,] Array = new int[n, n]; // ввели двумерный массив размером n = 4x4


int number = 1; // присвоили элементу массива number = 1 (начинаяс 1 как по заданию)
int i = 0;
int j = 0;

while (number <= Array.GetLength(0) * Array.GetLength(1)) // пока элемент массива <= произведения длин квадратов должны выполняться условия
{
  Array[i, j] = number;
  number++;
  if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Array.GetLength(1) - 1)
    j--;
  else
    i--;
}
PrintArray(Array);

void PrintArray(int[,] GetArray)
{
    for (int i = 0; i < GetArray.GetLength(0); i++)
    {
        for (int j = 0; j < GetArray.GetLength(1); j++)
        {
            Console.Write(GetArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}