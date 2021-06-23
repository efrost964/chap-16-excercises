using System;

namespace chap_16_studio
{
    class Program
    {
        static int Division(int x, int y)
        {
            try
            {
                int answer = x / y;
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
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input another number:");
            int num2 = Int32.Parse(Console.ReadLine());
            int answer = Division(num1, num2);
            if (answer > 0)
            {
                Console.WriteLine(answer);
            }


        }
    }
}
