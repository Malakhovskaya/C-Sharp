/*Задача 66: Задайте значения M и N. Напишите программу, 
 которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.Write("Введите начальное число: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите конечное число: ");
int m = int.Parse(Console.ReadLine());

int SumNaturalNums(int n, int m)
{
    if (n > m) return 0;
    else return n + SumNaturalNums(n + 1, m);
}
Console.WriteLine($"Сумма натуральных элементов между числами равняется {SumNaturalNums(n + 1, m) + n} ");
