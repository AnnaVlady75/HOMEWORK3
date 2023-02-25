﻿// Задача 27: Напишите программу, которая 
// принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(number);

Console.WriteLine($"Сумма цифр в числе {number} -> {SumDigits(number)}");

int SumDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10; //   res = res + num%10;
        num = num / 10;
    }
    return res;
}






