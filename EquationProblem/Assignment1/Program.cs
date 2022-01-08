using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            double min = double.MaxValue;
            double max = double.MinValue;
            int numberofPos = 0;
            int numberofNeg = 0;
            int numberofzero = 0;
            // input for N
            Console.Write("Please, enter the value of N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Please, enter the value of x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Please, enter the value of x1");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please, enter the value of x2");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please, enter the value of x3");
                double x3 = double.Parse(Console.ReadLine());

                if ((x1 <= x) & (x <= x2))
                {
                    f = ((x - x1) / (x2 - x1)) * (x3 - x1);

                }
                else if ((x2 < x) & (x <= x3))
                {
                    f = ((x - x2) / (x3 - x2)) * (x2 - x1);
                }
                else if (x > x3)
                {
                    f = x3;
                }
                else
                {
                    Console.WriteLine("Conditions were not fulfilled");
                    continue;
                }
                    
           
                Console.WriteLine("f = " + f);

                //updating minimum values
                if(f < min)
                {
                    min = f;
                }

                //updating maximum values
                if (f > max)
                {
                    max = f;
                }

                // Negative, zero, positive
                if(f<0)
                {
                    numberofNeg += 1;
                }
                else if(f==0)
                {
                    numberofzero += 1;
                }
                else if(f>0)
                {
                    numberofPos += 1;
                }
            }

            //min value
            if (min == double.MaxValue)
            {
                Console.WriteLine("No minimum value was found");

            }
            else
            {
                Console.WriteLine("Minimum value of f is: " + min);
            }

            //max value
            if (max == double.MinValue)
            {
                Console.WriteLine("No maximum value was found");

            }
            else
            {
                Console.WriteLine("Maximum value of f is: " + max);
            }

            // total number of Negative, zero, positive
            Console.WriteLine("Number of Negative f: " + numberofNeg);
            Console.WriteLine("Number of zero f: " + numberofzero);
            Console.WriteLine("Number of Positive f: " + numberofPos);


        }
    }
}
