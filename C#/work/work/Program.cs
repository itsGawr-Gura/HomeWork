using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Задание 1. Напишите мир труд май.
            Console.WriteLine("Задание 1. Напишите мир труд май.");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир \n  Труд \n     Май");
            // Задание 2. Поменяйте местами 2 переменные.
            Console.WriteLine("Задание 2. Поменяйте местами 2 переменные.");
            Console.Write("Введите первую переменную: ");
            string perem1 = Console.ReadLine();
            Console.Write("Введите вторую переменную: ");
            string perem2 = Console.ReadLine();
            Console.WriteLine($"{perem2} {perem1}");
            // Задание 3. Найти длину окружности и площадь круга.
            Console.WriteLine("Задание 3. Найти длину окружности и площадь круга.");
            Console.Write("Введите радиус: ");
            int radius;
            radius = Convert.ToInt32(Console.ReadLine());
            double pi = Math.PI;
            Console.WriteLine("Длина окружности = " + 2 * pi * radius);
            Console.WriteLine("Площадь круга = " + pi * radius * radius);
            // Задание 4. Найдите значение y=cos(x).
            Console.WriteLine("Задание 4. Найдите значение y=cos(x).");
            double x;
            Console.Write("Введите значение x в градусах: ");
            x = Convert.ToDouble(Console.ReadLine());
            double otvet;
            otvet = Math.Cos(x);
            Console.WriteLine("y= " + otvet);
            // Задание 5. Найти корни квадратного уравнения.
            Console.WriteLine("Задание 5. Найти корни квадратного уравнения.");
            int a;
            Console.Write("Введите коэфициэнт a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэфициэнт b= ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэфициэнт c= ");
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            int deskrim;
            deskrim = b * b - 4 * a * c;
            if (deskrim > 0)
            {
                int x1;
                int x2;
                double sqrtdeskrim = Math.Sqrt(deskrim);
                x1 = (int)((-b + sqrtdeskrim) / 2 * a);
                x2 = (int)((-b - sqrtdeskrim) / 2 * a);
                Console.WriteLine("Ваши корни = " + $"{x1}, {x2}");
            }
            else if (deskrim == 0)
            {
                int x1;
                x1 = -b / 2 * a;
                Console.WriteLine("Ваш корень = " + x1);
            }
            else if (deskrim < 0)
            {
                Console.WriteLine("Нет решений");
            }
            // Задание 6. Составить программу обмена значениями 3-ёх элементов.
            Console.WriteLine("Задание 6. Составить программу обмена значениями 3-ёх элементов.");
            Console.Write("Введите значение переменной a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение переменной b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение переменной c = ");
            c = Convert.ToInt32(Console.ReadLine());
            int b1, b2, a1, a2, c1, c2;
            b1 = c; a1 = b; c1 = a;
            b2 = a; c2 = b; a2 = c;
            Console.WriteLine($"По схеме а значения переменных следующие -  a=" + a1 + " b=" + b1 + " c=" + c1);
            Console.WriteLine($"По схеме b значения переменных следующие -  a=" + a2 + " b=" + b2 + " c=" + c2);
            // Задание 7. 4 случайных числа столбиком.
            Console.WriteLine("Задание 7. 4 случайных числа столбиком.");
            Random rnd1 = new Random();
            int d;
            a = rnd1.Next(-1000000000, 1000000000);
            b = rnd1.Next(-1000000000, 1000000000);
            c = rnd1.Next(-1000000000, 1000000000);
            d = rnd1.Next(-1000000000, 1000000000);
            Console.WriteLine($"{a} \n{b} \n{c} \n{d}");
            // Задание 8. Измененное 3-ёх значное число.
            Console.WriteLine("Задание 8. Измененное 3-ёх значное число.");
            Console.Write("Введите 3-ёх значное число -  ");
            int trexznach;
            trexznach = Convert.ToInt32(Console.ReadLine());
            int lastFigure = trexznach % 10;
            int pervieDve = trexznach / 10;
            string pervieDve1;
            pervieDve1 = Convert.ToString(pervieDve);
            string lastFigure1;
            lastFigure1 = Convert.ToString(lastFigure);
            string newTrexznach = lastFigure1 + pervieDve1;
            Console.WriteLine(newTrexznach);
            // Задание 9. Найти стоимость покупки.
            Console.WriteLine("Задание 9. Найти стоимость покупки.");
            Console.Write("Цена 1кг конфет - ");
            int costCandy;
            costCandy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена 1кг печенья - ");
            int costCookie;
            costCookie = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена 1кг яблок - ");
            int costApple;
            costApple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вам нужно кг конфет?");
            int kgCandy;
            kgCandy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вам нужно кг печенья?");
            int kgCookie;
            kgCookie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вам нужно кг яблок?");
            int kgApple;
            kgApple = Convert.ToInt32(Console.ReadLine());
            int cost = costCandy * kgCandy + costApple * kgApple + costCookie * kgCookie;
            Console.WriteLine("В таком случае с вас - " + cost + "$");
        }
    }
}
