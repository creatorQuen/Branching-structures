using System;

namespace Example_in_class
{
    /// <summary>
    /// Вывести на консоль входит ли введенное значение пользователем в диапозон.
    /// [10 ; 30] и [50 ; 80].
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while(Console.ReadLine() != "q")
            {
                string number;

                Console.WriteLine("Введите число:");
                number = Console.ReadLine();
                double a = Convert.ToDouble(number);

                if (a >= 10)
                {
                    if (a <= 30)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        if (a >= 50)
                        {
                            if (a <= 80)
                            {
                                Console.WriteLine("+");
                            }
                            else
                            {
                                Console.WriteLine("-");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
