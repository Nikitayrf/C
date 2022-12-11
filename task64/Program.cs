/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void PrintInt(int N, int count)
{
    if(N  == 1)
    {
        Console.Write("1");
        return;
    }
    Console.Write($"{count--}, ");
    PrintInt(N - 1, count);
};

Console.Write("Введите значение N : ");
int N = Convert.ToInt32(Console.ReadLine());
int count = N;
PrintInt(N, count);