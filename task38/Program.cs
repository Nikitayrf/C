// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * new Random().Next(-10,10);
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

Console.Write("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);
Console.WriteLine(string.Join(", ", array));

int imax = 1;
int imin = 1;
double difference = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > array[imax])
    {
        imax = i;
    }
    else
    {
        if (array[i] < array[imin])
        {
            imin = i;
        }
    }
    difference = array[imax] - array[imin];
    difference = Math.Round(difference, 2); // так как числа вещественные, убираем погрешность плавующей запятой
}
Console.WriteLine($"Разница между максимальным и минальным значение равна : {difference}");
