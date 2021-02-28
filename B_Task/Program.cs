using System;

namespace B_Task
{
    /// <summary>
    /// Пользователь вводит 2 числа (X и Y). 
    /// Определить какой четверти принадлежит точка с координатами (X,Y).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while(Console.ReadLine() != "q")
            {
                string firstInput;
                string secondInput;

                Console.WriteLine("Введиде два числа (X и Y) для того, чтобы " +
                    "определить какой четверти принадлежит точка с координатами (X,Y)");

                Console.WriteLine("Первое число (X):");
                firstInput = Console.ReadLine();
                double firstNumber = Convert.ToDouble(firstInput);

                Console.WriteLine("Второе число (Y):");
                secondInput = Console.ReadLine();
                double secondNumber = Convert.ToDouble(secondInput);

                if (firstNumber > 0)
                {
                    if (secondNumber > 0)
                    {
                        Console.WriteLine("Точка находится в I четверти.");
                    }
                    else if (secondNumber < 0)
                    {
                        Console.WriteLine("Точка находится в IV четверти.");
                    }
                    else
                    {
                        Console.WriteLine("Точка находится на оси x");
                    }
                }
                else if (firstNumber == 0 && secondNumber == 0)
                {
                    Console.WriteLine("Точка находится в начале координат");
                }
                else
                {
                    if (secondNumber > 0)
                    {
                        Console.WriteLine("Точка находится в II четверти.");
                    }
                    else
                    {
                        Console.WriteLine("Точка находится в III четверти.");
                    }
                }
            }
        }
    }
}
