/* Напишите программу для подсчета количества цифр в числе с помощью рекурсии.

12345 -> 5 */

Console.WriteLine("Ведите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

void recursion(int num, int count)
{
    if (num == 0)
    {
        Console.WriteLine($"Количество цифр в числе равно : {count}");
        return;
    }
    count++;
    recursion(num / 10, count);
}

recursion(num, count);