/* Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7  */

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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

string temp = $"({0},{0})";
int min = matrix[0, 0];
int imin = 0;
int jmin = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < matrix[imin, jmin])
        {
            imin = i;
            jmin = j;
            min = matrix[i, j];
            temp = $"({i},{j})";
        }
    }
};
Console.WriteLine(min + temp + imin + jmin);
Console.WriteLine();

int[,] resultMatrix = new int[rows - 1, columns - 1];
int inew = 0;
int jnew = 0;
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    if (i >= imin) inew = i + 1;
    else inew = i;

    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        if (j >= jmin) jnew = j + 1;
        else jnew = j;
        resultMatrix[i, j] = matrix[inew, jnew];
    }
};

PrintMatrix(resultMatrix);