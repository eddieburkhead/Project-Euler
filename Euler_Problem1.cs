using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Euler_Problem1
    {
        public static void Problem1()
            {
              int sum = 0;
              for(int i = 0; i < 1000; i++) 
               { 
                  if (i % 3 == 0 || i % 5 == 0)
                    {
                      sum = sum + i;  
                    } 
                  else
                    { 
                      continue;
                    }
                }
            }
    }
}
