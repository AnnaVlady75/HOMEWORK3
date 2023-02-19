// Задача 19 Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number <= 99999) IsPalindrome(number);
else Console.WriteLine($"Ошибка ввода: число {number} НЕ пятизначное ");



void IsPalindrome(int num)
{
    int firstPair = num;
    int lastpair = 0;
    while (firstPair != 0)
    {
        int lastDigit = firstPair % 10;
        lastpair = lastpair * 10 + lastDigit;
        firstPair = firstPair / 10;
    }
    if(num == lastpair)
    {
        Console.Write($"Число {num} является палиндромом");
    }
    else
    {
        Console.Write($"Число {num} НЕ является палиндромом");
    }
}







