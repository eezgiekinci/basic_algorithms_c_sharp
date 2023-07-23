
using System;

class Program
{
    public static int Find_Absolute_Value(int n)
    {
        if (n > 0)
            return n;

        else if (n < 0)
            return -1 * n;

        else
            return 0;

    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("|{0}| = {1}", n, Find_Absolute_Value(n));
    }
}