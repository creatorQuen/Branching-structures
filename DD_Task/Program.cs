using System;

namespace DD_Task
{
    /// <summary>
    /// Пользователь вводит 3 числа (A, B и С). 
    /// Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadLine() != "q")
            {
                string firstInput;
                string secondInput;
                string thirdInput;
                double D;

                Console.WriteLine("Первое число квадратного уравнения стандартного вида, где AX2+BX+C=0.");
                Console.WriteLine("Первое число (A):");
                firstInput = Console.ReadLine();
                double firstNumber = Convert.ToDouble(firstInput);

                Console.WriteLine("Второе число (B):");
                secondInput = Console.ReadLine();
                double secondNumber = Convert.ToDouble(secondInput);

                Console.WriteLine("Третье число (C):");
                thirdInput = Console.ReadLine();
                double thirdNumber = Convert.ToDouble(thirdInput);

                D = Math.Pow(secondNumber, 2) - 4 * firstNumber * thirdNumber;
                Console.WriteLine($"Дискриминант (D) равен: {D}");

                if (D < 0)
                {
                    Console.WriteLine("Нет корней");

                }
                else if (D == 0)
                {
                    double x = -secondNumber / (2 * firstNumber);
                    Console.WriteLine($"Существует один корень: X = {x}");
                }
                else if (D > 0)
                {
                    double x1 = (-secondNumber + Math.Pow(D, 0.5d)) / (2 * firstNumber);
                    double x2 = (-secondNumber - Math.Pow(D, 0.5d)) / (2 * firstNumber);

                    Console.WriteLine($"Существует два корня: X1 = {x1},  X2 = {x2}");
                }
            }
        }
    }
}
