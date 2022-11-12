// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите 1-е число : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-е число : ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}

Console.WriteLine(max);
