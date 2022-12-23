/*Задача 66: Задайте значения M и N. Напишите программу, 
 которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int m = InputInt("Введите положительное число M: ");
int n = InputInt("Введите положительное число N: ");

Console.WriteLine($"Сумма натуральных элементов между числами равняется = {SumNaturalNums(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int SumNaturalNums(int m, int n)
{
    if (m > n) return 0;
    else return m + SumNaturalNums(m + 1, n);
}
