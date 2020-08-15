using System;
using System.Collections;
using System.Collections.Generic;

namespace FindLargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number:");
            string numberAsString = Console.ReadLine();
            long number = long.Parse(numberAsString);

            if (IsPrime(number))
            {
                Console.WriteLine($"The number you entered ({number}) is prime!");
                return;
            }

            long i = 1;

            while (i <= number/2)
            {
                var isReminder = false;

                while (!isReminder)
                {
                    long reminder = number % i;
                    if (reminder == 0)
                    {
                        var isPrime = IsPrime(number / i);
                        if (isPrime)
                        {
                            Console.WriteLine(number / i);
                            return;
                        }
                        else
                        {
                            isReminder = true;
                        }                        
                    }

                    i++;                    
                }
            }

        }

        public static bool IsPrime(long number)
        {
            long i = 1;

            while (i <= number / 2)
            {
                var isReminder = false;

                while (!isReminder && i <= number / 2)
                {
                    long reminder = number % i;
                    if (reminder == 0)
                    {
                        if (i != number && i != 1)
                        {
                            return false;
                        }
                    }


                    if (i <= 2)
                    {
                        i++;
                    }
                    else
                    {
                        i += 2;
                    }                    
                }
            }

            return true;
            
        }
    }
}
