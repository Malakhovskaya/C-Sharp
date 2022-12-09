/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N */

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k += 2;

}
