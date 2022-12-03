/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void FillArray(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
};

Console.WriteLine("В массиве 3 строки и 4 стоблца");
Console.WriteLine("Введите позицию строки, в которой находиться элемент : ");
int userRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите позицию стоблца, в которой находиться элемент : ");
int userColumn = Convert.ToInt32(Console.ReadLine()) - 1;

int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];

FillArray(array, rows, columns);
Console.WriteLine();

void FindPosition(int[,] arr)
{
    if (arr.GetLength(0) <= userRow || arr.GetLength(1) <= userColumn)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Такого числа в массиве нет");
        Console.ResetColor();
        return;
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == userRow && j == userColumn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
                continue;
            }
            else
            {
                Console.Write(arr[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

FindPosition(array);