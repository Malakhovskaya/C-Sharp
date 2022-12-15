/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Необходимо ввести количество строк массива: ");
int rows=int.Parse(Console.ReadLine());  //int- потому что кол-во строк - это целое число

Console.Write("Необходимо ввести количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10); //double - т.к. у чисел есть дробная часть по условию задачи. Вводим метод заполнения двумерного массива по данным пользователя о кол-ве строк и столбцов
PrintArrayDouble(arrayDouble); // выводим заполненный массив в терминале

double[,] GetArrayDouble(int m, int n, int min, int max) //метод для рандомного заполнения массива m×n
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] Array) //метод вывода в терминал
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}
