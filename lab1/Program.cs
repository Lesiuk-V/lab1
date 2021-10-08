using System;
using System.Collections.Generic;

namespace lab1
{
    class Program
    {
        //функція для пошуку кількості цифр в числі
        static int FindCountOfNumbers(int n)
        {
            int count = (n == 0) ? 1 : 0;
            while (n != 0)
            {
                count++;
                n /= 10;
            }
            Console.WriteLine($"Кількість цифр в числі - { count }");
            return count;
        }
        // функція для створення масиву із чисел числа n
        static int[] ArrayFromNumber(int n, int count)
        {
            if (n == 0) return new int[1] { 0 };
            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();

            for (int i = 0; i < count / 2; ++i)
            {
                int holder = arr[i];
                arr[i] = arr[count - 1 - i];
                arr[count - 1 - i] = holder;
            }
            Console.WriteLine("v mas:");
            foreach (int el in arr)
            {
                Console.Write($"{el} ");
            }
            return arr;
        }
        // середнє арифметичне чисел
        static void ArithmetiMean(int[] arr, int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }
            double arufm = 0;
            arufm = sum / count;
            Console.WriteLine($"Середнє арифметичне = {arufm}");
        }
        // середнє геометричне чисел
        static void GeometricMean(int[] arr, int count)
        {
            double dob = 1;
            for (int i = 0; i < count; i++)
            {
                dob *= arr[i];
            }
            double geom;
            geom = Math.Pow(dob, 1.0 / count);
            Console.WriteLine($"Середнє геометричне = {geom}");
        }
        //Факторіал
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Факторіал { n } це: { fact }");
        }
        //сума парних чисел
        static void SumOfEvenNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { sum += i; }
            }
            Console.WriteLine($"Сума парних чисел: {sum}");
        }
        // сума непарних чисел
        static void SumOfNonEvenNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                { sum += i; }
            }
            Console.WriteLine($"Сума не парних чисел: {sum}");
        }
        // перевантаження для 6 ф
        static void SumOfEvenNumbers(int a, int b, int n)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                { sum += i; }
            }
            Console.WriteLine($"Сума парних чисел від {a} до {b}: {sum}");
        }
        // перевантаження для 7ф
        static void SumOfNonEvenNumbers(int a, int b, int n)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                { sum += i; }
            }
            Console.WriteLine($"Сума не парних чисел від {a} до {b}: {sum}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть будь яке ціле число");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = FindCountOfNumbers(n);
            int[] arr = ArrayFromNumber(n,count);
            ArithmetiMean(arr, count);
            GeometricMean(arr, count);
            factorial(n);
            SumOfEvenNumbers(n);
            SumOfNonEvenNumbers(n);
            Console.WriteLine("Введіть a та b для знаходження суми парних та непарних чисел в цтому діапазоні");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            SumOfEvenNumbers(a, b, n);
            SumOfNonEvenNumbers(a, b, n);
        }
    }
}
