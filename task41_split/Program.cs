/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите числа через пробел : ");
string num = Console.ReadLine();
string[] splitNum = num.Split(' ');

Console.WriteLine("[" + string.Join(", ", splitNum) + "]");
int count = 0;
int intNum = 0;
for (int i = 0; i < splitNum.Length; i++)
{
    intNum = int.Parse(splitNum[i].ToString());
    if (intNum > 0)
    {
        count++;
    }
}
Console.WriteLine("Пользователь ввёд цифр юольше 0 равное : " + count);