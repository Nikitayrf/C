/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] FillMatrix(int[,,] matr)
{
    int[,,] newMatr = new int[matr.GetLength(0), matr.GetLength(1), matr.GetLength(2)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                newMatr[i, j, k] = new Random().Next(1, 100);
                if(newMatr[i,j,k] == newMatr[i,j,k])
                {
                    newMatr[i,j,k] = new Random().Next(1, 100);
                }
                Console.Write(newMatr[i, j, k] + $"({i},{j},{k})" + " ");
            }
            Console.WriteLine();
        }
    }
    return newMatr;
}

int[,,] matrix = new int[2, 2, 2];
FillMatrix(matrix);