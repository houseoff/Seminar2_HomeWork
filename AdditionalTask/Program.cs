// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент

// Блок 1. Код для запуска в Visual Studio Code
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int SecondMax = 0, Max = 0;
        int n = Convert.ToInt32(Console.ReadLine());

        while (n != 0)
        {
            if (n > Max)
            {
                SecondMax = Max;
                Max = n;
            }
            else if (n > SecondMax)
                SecondMax = n;

            n = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(SecondMax);
    }
}



// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223
// using System;

// public class Program
// {
//     private static void Main(string[] args)
//     {
//         int SecondMax = 0;
//         int Max = 0;
//         int number = 0;
//     	   string[] s = Console.ReadLine().Split(' ');

//         for (int i = 0; i < s.Length; i++)
//         {
//         	   number = int.Parse(s[i]);
//             if (number != 0)
//             {
//                 if (number > Max)
//                 {
//                     SecondMax = Max;
//                 	   Max = number;
//             	   }
//             	   else if (number > SecondMax)
//                 {
//                     SecondMax = number;
//                 }
//         	   }
//             else
//             {
//                 break;
//             }
//         }

//         Console.WriteLine(SecondMax);
//     }
// }