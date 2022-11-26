// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[]arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99,1000);
    }
    return arr;
}

Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));

int count = 0;
for (int i =0; i < array.Length;i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
};
Console.WriteLine($"Колличество чётных чисел в массиве равно : {count}");