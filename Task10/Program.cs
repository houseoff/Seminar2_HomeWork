// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int n2 = (n / 10) % 10;
Console.WriteLine($"{n2}");