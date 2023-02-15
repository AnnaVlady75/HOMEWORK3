﻿// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = SecondNumber(number);
Console.WriteLine($"Вторая цифра этого числа -> {secondNumber}");

int SecondNumber(int num)
{
    int secondDigit = num / 10;
    return secondDigit % 10;
}

