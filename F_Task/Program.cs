using System;

namespace F_Task
{
    /// <summary>
    /// Пользователь вводит двузначное число. 
    /// Выведите в консоль прописную запись этого числа. 
    /// Например при вводе “25” в консоль будет выведено “двадцать пять”.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.WriteLine("Введите двузначное число.");
            inputString = Console.ReadLine();
            int inputNumber = Convert.ToInt32(inputString);

            
            

            if((inputNumber > 9) && (inputNumber < 20))
            {
                switch (inputNumber)
                {
                    case 10:
                        Console.WriteLine("десять");
                        break;
                    case 11:
                        Console.WriteLine("одинадцать");
                        break;
                    case 12:
                        Console.WriteLine("двенадцать");
                        break;
                    case 13:
                        Console.WriteLine("тринадцать");
                        break;
                    case 14:
                        Console.WriteLine("четырнадцать");
                        break;
                    case 15:
                        Console.WriteLine("пятнадцать");
                        break;
                    case 16:
                        Console.WriteLine("шестнадцать");
                        break;
                    case 17:
                        Console.WriteLine("семнадцать");
                        break;
                    case 18:
                        Console.WriteLine("восемнадцать");
                        break;
                    case 19:
                        Console.WriteLine("девятнадцать");
                        break;
                }
            }
            else if (inputNumber >= 20)
            {
                int inputNumberDec = inputNumber / 10;
                switch (inputNumberDec)
                {
                    case 2:
                        Console.Write("двадцать");
                        break;
                    case 3:
                        Console.Write("тридцать");
                        break;
                    case 4:
                        Console.Write("сорок");
                        break;
                    case 5:
                        Console.Write("пятьдесят");
                        break;
                    case 6:
                        Console.Write("шестьдесят");
                        break;
                    case 7:
                        Console.Write("семьдесят");
                        break;
                    case 8:
                        Console.Write("восемьдесят");
                        break;
                    case 9:
                        Console.Write("девяносто");
                        break;
                }

                int inputNumberOne = inputNumber % 10;
                switch (inputNumberOne)
                {
                    case 1:
                        Console.Write(" один");
                        break;
                    case 2:
                        Console.Write(" два");
                        break;
                    case 3:
                        Console.Write(" три");
                        break;
                    case 4:
                        Console.Write(" четыре");
                        break;
                    case 5:
                        Console.Write(" пять");
                        break;
                    case 6:
                        Console.Write(" шесть");
                        break;
                    case 7:
                        Console.Write(" семь");
                        break;
                    case 8:
                        Console.Write(" восемь");
                        break;
                    case 9:
                        Console.Write(" девять");
                        break;
                }
            }
            


        }
    }
}
