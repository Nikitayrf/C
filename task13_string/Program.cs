// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");

int intNum = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string strNum = Convert.ToString(intNum);

if (strNum.Length < 3)
{
    Console.Write("третьей цифры нет");
}
else
{
    char thirdDigit = strNum[2];
    Console.WriteLine(thirdDigit);
};
