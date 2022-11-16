// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

double newNumber = Convert.ToDouble(num);

if (newNumber > 1000)
{
    while (true)
    {
        newNumber = Math.Floor((newNumber * 0.1));
        if (newNumber < 1000)
        {
            newNumber = (newNumber % 100) % 10;
            Console.WriteLine(newNumber);
            break;
        }
    }
}
else if (newNumber < 1000 && newNumber >= 100)
{
    newNumber = (newNumber % 100) % 10;
    Console.WriteLine(newNumber);
}
else
{
    Console.Write("третьей цифры нет");
}