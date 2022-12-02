/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число : ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
};

Console.WriteLine("Введите сколько будет введено чисел :");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
};

Console.WriteLine($"Колличество цифр введнных пользователем больше 0 равно " + count);
