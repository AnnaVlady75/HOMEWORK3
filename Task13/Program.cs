﻿// Задача 13: Напишите программу, которая
// выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = ThirdGigit(number);

if (number > 99) Console.WriteLine($"Третья цифра числа {thirdDigit}");
else Console.WriteLine("-> Третьей цифры нет");

int ThirdGigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}


