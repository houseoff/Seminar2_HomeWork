// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введите число от 1 до 7 включительно: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7)
    Console.WriteLine("Вы ошиблись. Введите число от 1 до 7 включительно");
else if (n == 6 || n == 7)
    Console.WriteLine("Выходной день");
else
    Console.WriteLine("Будний день");
