﻿// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите number 1: ");
int number1 = int.Parse(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.Write("Данное число является чётным");
}
else
{
    Console.Write("Данное число является нечётным");

}

