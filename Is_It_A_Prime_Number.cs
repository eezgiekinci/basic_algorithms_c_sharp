
using System;

class Is_It_A_Prime_Number
{
    public static bool Is_It_Prime_Number(int n)
    {
        if (n <= 1)
        {
            Console.WriteLine("Numbers which are less than or equal to one are not prime numbers.");
            return false;
        }

        else
        {
            bool control = true;

            for (int i =2; i < n; i++)
            {
                if( n % i == 0) // If a number is divisible by another number, that number is not a prime number.
                {
                    control = false;
                    break;
                }
            }
            return control;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}" , Is_It_Prime_Number(n) ? "A Prime Number" : "Not A Prime Number");
    }
}
