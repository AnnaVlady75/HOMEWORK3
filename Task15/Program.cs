// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int figureWeek = Convert.ToInt32(Console.ReadLine());

if (Weekend(figureWeek)) Console.WriteLine("->День является выходным");
else Console.WriteLine("->День НЕ является выходным");

bool Weekend(int fig)
{
    return fig == 6 || fig == 7;
}