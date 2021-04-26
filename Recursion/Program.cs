using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int sum = 0;
            int degr = 1;
            int countSum = 0;
             countSum = Degree(x, sum, degr, countSum);
            Degree(x,sum,degr, countSum);
            Console.WriteLine($"summary is = {countSum}");

        }
        static int Degree(int x,int sum,int degr, int countSum)
        {
            degr *= 2;
            sum = degr;
            sum += degr;
            countSum += sum;

            if (x == 10)
            {
              
                Console.WriteLine($"{x}  = x and {sum} = sum");
                return countSum;
                
            }
            else
            {
               
                Console.WriteLine($"{x}  = x  and {sum } = sum");                
                return Degree(x + 1,sum,degr, countSum);
            }
        }

    }
    }

