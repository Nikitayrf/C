// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Должно работать в том, числе с отрицательными

    Console.WriteLine("Введите 5-ти значное число: ");
    string num = Console.ReadLine();
    num = num.Replace("-", "");
    if (num.Length == 5){
        int count = 0;
        for (int i = 0; i < num.Length / 2; i++) {
            if (num[i] == num[num.Length - 1 - i]) {
                count++;
            }
        }
        if (count == (num.Length - 1) / 2) {
            Console.WriteLine("да");
        } else {
            Console.WriteLine("нет");
        }
    }
    else{
        Console.WriteLine("\nВнимание! Число не 5-ти значное");
    }
