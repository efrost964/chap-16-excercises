using System;

namespace chap_16_studio
{
    class Program
    {
        static double Division(double x, double y)
        {
            try
            {
                double answer = x / y;
                return answer;
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("Cannot divide by 0. Please reinput data correctly.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Division!");
            Console.WriteLine("Please input a number:");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input another number:");
            double num2 = Double.Parse(Console.ReadLine());
            double answer = Division(num1, num2);
            if (answer > 0)
            {
                Console.WriteLine(answer);
            }


        }
    }
}
