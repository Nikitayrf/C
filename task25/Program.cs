/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
степень B.*/

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введитите число A : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введитите число B : ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = 1;
for (int i = 1; i <= b;i++)
{
    sum = sum * a;
}
Console.WriteLine(sum);