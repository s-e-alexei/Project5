using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            task12();
            //task27();
            //task44();
            //task68();
            // Console.WriteLine(task27(1, 3));

        }

        private static void task12()
        {
            double d, d1, r = 6350;
            int h1 = 350;
            //d1 = Math.Sqrt(h1 * (2 * r + h1));
            d1 = Math.Sqrt(Math.Pow((r + h1), 2) - r * r);
            for (int h = 1; h <= 10; h++)
            {
                d = Math.Sqrt(Math.Pow((r + h), 2) - r * r);
                Console.WriteLine($"Растояние с высотой над Землеё={h} км\t Состовляет {d} км");
            }
            Console.WriteLine($"{h1}\t{d1}");
            Console.ReadLine();
        }

        private static void task44()
        {
            {
                int k = 2, n = 500;

                double result = Math.Sqrt(k * n);

                for (int i = n - 1; i >= 1; i--)
                {
                    result = Math.Sqrt(k * i + result);
                    Console.WriteLine(result);
                    //Console.Write($"{result}");
                }
                Console.ReadLine();
            }

        }

        private static void task68()
        {
            double sumIN = 1000, pct = 2, prirost = 0,
                   sumPr, sumVK, summa = sumIN;                              // pct- проценты, 
                                                                             //sumIN - сумма инвестиций, 
                                                                             //monthNm1200 - месяц с превышением вклада в 120грн.           
            int month = 12, monthNm = 0, monthNm1200 = 0;
            for (int i = 1; i <= 10; i++)
            {
                sumPr = (summa + (summa * pct / 100)) - summa;
                summa += sumPr;
                Console.WriteLine($"На {i} месяце\t прирост {sumPr} гривен");
            }
            for (int j = 3; j <= 12; j++)
            {
                sumVK = summa + (summa * pct / 100);
                summa += sumVK;
                Console.WriteLine($"{j}\t{sumVK}");
            }

            do
            {
                prirost = summa * pct / 100;
                summa = summa + prirost;
                monthNm++;
                if (summa > 1200 && monthNm1200 == 0)
                    monthNm1200 = monthNm;
            }
            while (prirost < 30);
            Console.WriteLine($"Величина ежемесячного вклада превысит 30грн. на {monthNm} месяце" +
                $"\nРазмер вклада превысит 1200грн. на {monthNm1200} месяце");
            Console.ReadLine();
        }

        private static void task27()
        {
            int k = 0, f = 1;
            double sum = 0, x = 2;
            for (int i = 1; i <= 13; i += 2)
            {
                sum += Math.Pow(x, i) * (k++ % 2 == 0 ? 1 : -1) / f;
                f = f * (i + 1) * (i + 2);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static void task9()
        {
            const double unitprice = 20.40;
            for (int i = 2; i <= 20; i++)
            {
                //Console.WriteLine("Цена за {0} едениц товара: {1} гривен", i, unitprice * i);
                Console.WriteLine($"Стоимость {String.Format("{0:C}", i * unitprice)}");
            }

        }

        private static void task8()
        {
            int a = 12345679;
            for (int i = 9; i <= 81; i += 9)
            {
                Console.WriteLine($"{a * i}");
            }
            Console.ReadLine();
        }

        private static void task6(int m = 100)
        {
            for (int t = 0; t <= m; t++)
            {
                Console.WriteLine($"|Цельсий {t}\t |\t Фрнгейт{(9 * t / 5) + 32}");
            }
            Console.ReadLine();
        }

        private static void task2(int n = 100)
        {
            Console.WriteLine($"Все делители числа {n}");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Делитель: " + i);
                }
            }
            Console.ReadLine();
        }

        private static void task5()
        {
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine($"|\t{Math.Pow(a, 2)}\t|\t{Math.Pow(a, 3)}\t|");
            }
            Console.ReadLine();
        }

    }
}