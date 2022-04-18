using System;

namespace Number_divided_by_seven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, include number");
            int num = Convert.ToInt32(Console.ReadLine());

            int remainder;
            if (num % 7 == 0)
            {
                Console.WriteLine("Number divided by seven");
            }
            else
            {
                remainder = num % 7;
                if (remainder >= 4)
                {
                    Console.WriteLine("The nearest number divisible by seven:   " + ((num - remainder) + 7));
                }
                else if (0 <= remainder || remainder < 4)
                {
                    Console.WriteLine("The nearest number divisible by seven:  " + (num - remainder));
                }




            }
            
        }
    }
}
