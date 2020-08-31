using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectEuler
{
    public static class Euler_Problem2
    {

        public static long Problem2()
        {
           
          
            long sum1 = 0; //holds fibonacci numbers
            long sum2 = 2; //captures first even number in fib sequence
            long num1 = 1;
            long num2 = 2;


            while (sum1 <= 4000000)
            {
                if (sum1 % 2 == 0) //adds only even fibonacci numbers
                {
                    sum2 = sum2 + sum1;
                }
               
                //initializes fibonacci sequence
                sum1 = num1 + num2;
                num1 = num2;
                num2 = sum1;
                
            }

            return sum2;
        }




    }
}
