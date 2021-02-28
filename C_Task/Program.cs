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
                string firstInput;
                string secondInput;
                string thirdInput;

                Console.WriteLine("Первое число (A):");
                firstInput = Console.ReadLine();
                double firstNumber = Convert.ToDouble(firstInput);

                Console.WriteLine("Второе число (B):");
                secondInput = Console.ReadLine();
                double secondNumber = Convert.ToDouble(secondInput);

                Console.WriteLine("Третье число (C):");
                thirdInput = Console.ReadLine();
                double thirdNumber = Convert.ToDouble(thirdInput);

                if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Последовательность в порядке возрастания:");

                    if (secondNumber > thirdNumber)
                    {

                        Console.WriteLine($"{thirdNumber}");
                        Console.WriteLine($"{secondNumber}");
                        Console.WriteLine($"{firstNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{secondNumber}");
                        Console.WriteLine($"{thirdNumber}");
                        Console.WriteLine($"{firstNumber}");
                    }
                }
                else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Последовательность в порядке возрастания:");


                    if (firstNumber > thirdNumber)
                    {

                        Console.WriteLine($"{thirdNumber}");
                        Console.WriteLine($"{firstNumber}");
                        Console.WriteLine($"{secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber}");
                        Console.WriteLine($"{thirdNumber}");
                        Console.WriteLine($"{secondNumber}");
                    }
                }
                else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Последовательность в порядке возрастания:");

                    if (firstNumber > secondNumber)
                    {

                        Console.WriteLine($"{secondNumber}");
                        Console.WriteLine($"{firstNumber}");
                        Console.WriteLine($"{thirdNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber}");
                        Console.WriteLine($"{secondNumber}");
                        Console.WriteLine($"{thirdNumber}");
                    }
                }
            }

        }
    }
}
