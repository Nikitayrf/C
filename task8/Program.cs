// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N : ");
int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 2; i <= numberN; i = i + 2)
{
    Console.Write($"{i} ");
}