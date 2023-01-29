// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введенное число: {n}");
if (n / 10 == 0)
    Console.WriteLine($"Число {n} состоит из одной цифры");
else
{
    int n2 = (n / 10) % 10;
    Console.WriteLine($"Вторая цифра числа: {n2}");
}