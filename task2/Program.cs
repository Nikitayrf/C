// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите 1-е число : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}, min = {numberB}");
}
else if (numberB > numberA)
{
    Console.WriteLine($"max = {numberB}, min = {numberA}");
}
else
{
    Console.WriteLine($"Два числа равны и равны {numberA}");
}