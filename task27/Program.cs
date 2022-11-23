// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// С первым отрицательным числом должно работать.

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int firstnum = Math.Abs(num);
while (firstnum >= 10) // Определяем первую цифру в числе
{
    firstnum = firstnum / 10;
}
Console.WriteLine(firstnum);
int GetLength(int number) // Определяем длинну числа математическим методом с помощью рекурсии.
{
    if (number > 9 || number < -9)
    {
        return GetLength(number / 10) + 1;
    }
    else
    {
        return 1;
    }
}
int length = GetLength(num);

int sum = 0;
int positiveNum = Math.Abs(num);
int ostatok = 0;
for (int i = 0; i < length; i++)
{
    ostatok = (positiveNum % 10);
    sum = sum + ostatok;
    positiveNum = (positiveNum - ostatok) / 10;
    if (num < 0 && i == length-1)
    {
        sum = sum  - (firstnum * 2) ;
        Console.WriteLine($"Сумма цифр в отрицательном числе равна : {sum}");
        return;
    }
}
Console.WriteLine($"Сумма числе в числе равна : {sum}");
