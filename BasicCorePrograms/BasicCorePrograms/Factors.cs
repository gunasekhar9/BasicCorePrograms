using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void Factor()
        {
            Console.WriteLine("Enter the Number to Calculate is Factors :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (int i = 2; i*i <= number; i++)
            {
                while (number % i == 0)                
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }
            if (number >1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Those are the Factors ");
        }
    }
}