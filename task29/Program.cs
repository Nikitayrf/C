// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите какого размера будет массив :");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lengthArray];

for (int i = 0; i < lengthArray; i++)
{
    Console.Write($"Введите {i + 1} - ый элемент массива : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write('[' + string.Join(", ", array) + ']');