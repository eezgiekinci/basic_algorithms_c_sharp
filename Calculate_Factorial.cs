using ConsoleApp6;

using System;

public class Mathematics
{
    public static int Factorial(int number)
    {
        if (number <= 1)
            return 1;   

        int f = 1;

        for (int i = 2; i <= number; i++)
        {
            f *= i;
        }

        return f;
    }
}


// MAIN 

class Calculate_Factorial
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}!: {1}", number,
        Mathematics.Factorial(number));
    }
}
    
