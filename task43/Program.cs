/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 =9 -> (-0,5; -0,5) */

Console.WriteLine("Введите занчение b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите занчение k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите занчение b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите занчение k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 - k2 == 0)
{
    Console.WriteLine("Прямые парллельные");
}
else
{
    x = Math.Round((b1 - b2) / (k2 - k1), 2);
    y = Math.Round((k1 * x + b1), 2);
    Console.WriteLine($"({x}; {y})");
};