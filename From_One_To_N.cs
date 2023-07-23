
// It returns the sum of numbers from 1 to n.

using System;

class From_One_To_N
{
    public static int Total_Sum(int n)
    {
        int sum = 1;

        while(n > 1)
        {
            sum = sum + n;
            n = n - 1;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum of the numbers from 1 to {0} is {1}", n, Total_Sum(n));
    }
}