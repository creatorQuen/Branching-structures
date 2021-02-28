using System;

namespace C_Task
{
    /// <summary>
    /// Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
           while(Console.ReadLine() != "q")
           {
                double a, b, c, temp;
                Console.Write("Введите число a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число c: ");
                c = Convert.ToDouble(Console.ReadLine());

                if (a > b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                if (b > c)
                {
                    temp = b;
                    b = c;
                    c = temp;
                }
                if (a > b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }

                Console.WriteLine("Ответ: " + a + " " + b + " " + c);
           }

        }
    }
}
