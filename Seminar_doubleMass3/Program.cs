// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве  
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. 
// m = 3, n = 4. 
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5 

Console.Write("Введите количество строк массива: "); 
var rows=int.Parse(Console.ReadLine()); 

Console.Write("Введите количество столбцов массива: "); 
int columns=int.Parse(Console.ReadLine()); 
int[,] array = new int[rows,columns]; 


for (int i = 0; i < rows; i++) 
{ 
    for (int j = 0; j < columns; j++) 
        array[i,j] = i+j; 
} 

for (int i = 0; i < rows; i++) 
{ 
    for (int j = 0; j < columns; j++) 
        Console.Write(array[i,j]+" "); 
         
    Console.WriteLine();     
}

