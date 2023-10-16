namespace eto_ne_proect
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

        /*
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
        */

        //task 3
        /*
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int m);
            int.TryParse(Console.ReadLine(), out int n);

            int result = kolvo(m, n);
            Console.WriteLine(result);
        }

        static int kolvo(int m, int n)
        {
            if (n == 0 || m == 0)
                return 1;
            return kolvo(m, n - 1) + kolvo(m - 1, n - 1);
        }
        */

        // task 4

        /*
        public static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double xn);
            double.TryParse(Console.ReadLine(), out double xk);
            double.TryParse(Console.ReadLine(), out double epsy);

            int result = reshenie();
        }
        static int reshenie(double xk, double xn, double epsy)
        {
            if (xk - xn > epsy)
            {

                double dx = (xk - xn) / 2;
                double xi = xn + dx;
                if (xn < 0 && xi > 0 || xn > 0 && xi < 0)
                {
                    xk = xi;
                }
                else
                    xn = xi;
                reshenie(xk, xn, epsy);
                return xi;
                
            }
            return 1;
        }    
        */

        // task 6
        public static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double i);
            double.TryParse(Console.ReadLine(), out double j);

        }
    }   
}
