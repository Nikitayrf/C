/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка */

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
};

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
};

Console.Write("Введите сколько будет строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сколько будет столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

int[] sumArr = new int[rows];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
    sumArr[i] = sum;
};

void FindStringWithMinimumSumOfElement(int[] arr)
{
    int imin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[imin]) imin = i;
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: " + (imin + 1) + " строка");
}

FindStringWithMinimumSumOfElement(sumArr);