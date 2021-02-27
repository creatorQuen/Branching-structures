using System;

namespace A_Task
{
    /// <summary>
    /// Пользователь вводит 2 числа (A и B). 
    /// Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;

            Console.WriteLine("Введиде два числа");

            Console.WriteLine("Первое число (A):");
            firstInput = Console.ReadLine();
            double  firstNumber = Convert.ToDouble(firstInput);

            Console.WriteLine("Второе число (B):");
            secondInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondInput);

            if (firstNumber > secondNumber)
            {
                var operattionPlus = firstNumber + secondNumber;
                Console.WriteLine($"A+B равно:{operattionPlus}");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine($"A*B равно: {firstNumber * secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"A-B равно:{firstNumber - secondNumber}");
            }

        }
    }
}
