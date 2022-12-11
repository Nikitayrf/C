/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void PrintSum(int start, int end, int sum, int count)
{
    if (count == end)
    {
        Console.WriteLine(sum + start);
        return;
    }
    count++;
    sum += count;
    PrintSum(start, end, sum, count);
};

Console.Write("Введите число m : ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n : ");
int end = Convert.ToInt32(Console.ReadLine());

int count = start;
if (end < start) 
{
    int temp = end;
    end = start;
    start = temp;
    count = start;
};

int sum = 0;

PrintSum(start, end, sum, count);




