/* Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

Console.WriteLine("Программа по перемножению 2-х матриц.");
Console.WriteLine(" Кол-во столбцов 1-ой матрицы должно быть равно количеству строк 2-ой матрицы");

Console.WriteLine("Создайте 1-ю матрицу");
Console.Write("Введите сколько будет строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сколько будет столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = FillMatrix(rows, columns);
PrintMatrix(firstMatrix);

Console.WriteLine();

Console.WriteLine("Создайте 2-ю матрицу");
Console.Write("Введите сколько будет строк : ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сколько будет столбцов : ");
columns = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = FillMatrix(rows, columns);
PrintMatrix(secondMatrix);

Console.WriteLine();

int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] = resultMatrix[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
};

PrintMatrix(resultMatrix);
