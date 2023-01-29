// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int divider = 100;
int count = 2;
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n / divider == 0)
    Console.WriteLine($"Число {n} состоит меньше чем из трех цифр");
else
{
    while (n / divider != 0)
    {
        count++;
        divider *= 10;
    }

    Console.WriteLine($"Число {n} состоит из {count} цифр");
    int n3 = Convert.ToInt32(n % Math.Pow(10,count-2) / Math.Pow(10,count-3));
    Console.WriteLine($"Третья цифра числа {n}: {n3}");
}
