/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

Console.Write("Введите ширину массива: ");
int number=int.Parse(Console.ReadLine()); 

int[,,] array = GetArray(rows, columns,number); //вводим метод рандомного заполнения массива 
//PrintArray(array); 
PrintIndex(array);

int[,,] GetArray(int rows, int columns, int number, int minValue=0, int maxValue=100)
{
    int[,,] result = new int[rows,columns,number];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                 result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}
/*
void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
          for (int k = 0; k < array.GetLength(1); k++)
          {
            Console.Write(array[i,j,k] );
          }
    Console.WriteLine();
    }
  }
}
*/

// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}