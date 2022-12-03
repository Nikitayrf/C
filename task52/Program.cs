/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите сколько в массиве будет строк и стоблцов");

Console.WriteLine("Введите сколько будет строк : ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сколько будет столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);

void FindAritheticMean(int[,] arr)
{
    double[] sumArr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        sumArr[j] = Math.Round(sum / arr.GetLength(0), 2);
    }
    Console.WriteLine("Среднее арифметическое каждого столбца");
    Console.WriteLine("[" + string.Join("; ", sumArr) + "]");
}

FindAritheticMean(array);