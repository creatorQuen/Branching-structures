using System;

namespace B_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string ans;
            Console.Write("Введите число a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
            {
                if (b != 0)
                {
                    if (b > 0)
                    {
                        ans = "1 четверть";
                    }
                    else
                    {
                        ans = "4 четверть";
                    }
                }
                else
                {
                    ans = "На положительной части оси Х";
                }
            }
            else if (a < 0)
            {
                if (b > 0)
                {
                    ans = "2 четверть";
                }
                else if (b < 0)
                {
                    ans = "3 четверть";
                }
                else
                {
                    ans = "На отрицательной части оси Х";
                }
            }
            else
            {
                if (b > 0)
                {
                    ans = "На положительной части оси Y";
                }
                else if (b < 0)
                {
                    ans = "На отрицательной части оси Y";
                }
                else
                {
                    ans = "Начало координат";
                }
            }

            Console.WriteLine(ans);
        }
    }
}