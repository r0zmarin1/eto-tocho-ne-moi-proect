﻿namespace eto_ne_proect
{
    class Program
    {
        /*
        public static void Main(string[] args) 
        { 
            // task 1

            int.TryParse(Console.ReadLine(), out int number);

            int result = CalcDigitSum(number);
            Console.WriteLine(result);
        }

        static int CalcDigitSum(int number)
        {
            if (number == 0)
                return 0;
            int digit = number % 10;
            return digit + CalcDigitSum(number / 10); // recurs
        }
        */

        // task 2
        public static void Main(string[] args) 
        {
            int.TryParse(Console.ReadLine(), out int number);

            int result = CalcNum(number);
            Console.WriteLine(result);
        }

        static int CalcNum(int number)
        {
            if (number == 0)
                return 0;
            return 1 + CalcNum(number / 10);
        }
    }
}
