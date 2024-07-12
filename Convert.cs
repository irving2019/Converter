using System;

/*  
    1) Напишите программу вычисляющую среднее арифмитическое трёх чисел
    2) Введите три числа и выведите на экран значения суммы и произведения этих чисел
    3) Напишите простой конвертер валют, валюты не изменяются
*/


namespace Lesson
{
    class App
    {
        public static void Main(string[] args)
        {
            App.ThreeCounts();
            App.Convers();
        }

        public static void ThreeCounts()
        {
            Console.WriteLine("Введите 3 числа: ");

            int count1, count2, count3;

            count1 = Convert.ToInt32(Console.ReadLine());
            count2 = Convert.ToInt32(Console.ReadLine());
            count3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nРезультат сложения: " + (count1 + count2 + count3));

            Console.WriteLine("\nРезультат умножения: " + (count1 * count2 * count3));

            Console.WriteLine("\nСреднее Арифметическое: " + (count1 + count2 + count3) / 3);
        }

        public static void Convers()
        {
            double dollar, euro, ruble_per_dollar, ruble_per_euro;

            Console.WriteLine("Введите кол-во долларов для конвертации: ");
            dollar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите кол-во евро для конвертации: ");
            euro = Convert.ToDouble(Console.ReadLine());

            ruble_per_dollar = 87.70 * dollar;
            ruble_per_euro = 95.49 * euro;

            Console.WriteLine($"Вы получите: {ruble_per_dollar} рублей с {dollar} доллара(ов)");
            Console.WriteLine($"Вы получите: {ruble_per_euro} рублей с {euro} евро");
        }
    }
}