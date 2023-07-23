
// It returns the sum of odd numbers from 1 to n.

using System;

class From_One_To_N_Odd
{
    public static int Total_Sum(int n)
    {
        int sum = 0;

        for(int i = 1; i <= n; i+=2)
        {
            sum = sum + i;
        }
        return sum;

    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum of the odd numbers from 1 to {0} is {1}", n, Total_Sum(n));
    }
}