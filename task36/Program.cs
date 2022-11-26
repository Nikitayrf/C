// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray (int size)
{
    int[] arr = new int[size];
    for(int i =0; i< arr.Length;i++)
    {
        arr[i] = new Random().Next(-99,100);
    }
    return arr;
};

Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));

int sum = 0;
for (int i = 0; i < array.Length;i++)
{
    if ( i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях равно : {sum}");