// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int x1 = SetNumber("x1");
int y1 = SetNumber("y1");
int z1 = SetNumber("z1");
int x2 = SetNumber("x2");
int y2 = SetNumber("y2");
int z2 = SetNumber("z2");

double result = DistanceBetween3DPoints(x1, x2, y1, y2, z1, z2);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

double DistanceBetween3DPoints(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine($"result {result}");
