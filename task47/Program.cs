/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() + new Random().Next(-10, 10);
            arr[i, j] = Math.Round(arr[i, j], 2);
            Console.Write(arr[i, j] + " | ");
        }
        Console.WriteLine();
    }
};

Console.WriteLine("Введите двумерный массив размера  m x n : ");
Console.WriteLine("Введите число строк m : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n : ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];

FillArray(array);