// Задача 19 Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 9999 || number > 99999)
    Console.WriteLine($"Ошибка ввода: число {number} НЕ пятизначное ");
else if (IsPalindrome(number))
    Console.Write($"Число {number} является палиндромом");
else
    Console.Write($"Число {number} НЕ является палиндромом");

bool IsPalindrome(int num)
{
    int firstPair = num;
    int lastPair = 0;
    while (firstPair != 0)
    {
        int lastDigit = firstPair % 10;
        lastPair = lastPair * 10 + lastDigit;
        firstPair = firstPair / 10;
    }
    return (num == lastPair);
}





