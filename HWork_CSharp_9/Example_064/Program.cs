// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите начальное число: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите конечное число: ");
int m = int.Parse(Console.ReadLine());
PrintNumber(n, m);

string NaturalNumbers(int n, int m)
{
    if (n <= m) return $"{n} " + NaturalNumbers(n + 1, m);
    else return String.Empty;
}

void PrintNumber(int n, int m)
{
Console.WriteLine($"Числа по порядку в указанном диапазоне: {NaturalNumbers(n, m)}");
}
