//It finds the sum of the digits of a number entered as a parameter.


using System;

class Sum_of_Digits
{
    public static int Sum_Number(int n)
    {
        int sum = 0, number = 0;

        while(n > 0)
        {
            number = n % 10;

            sum += number;

            n /= 10;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum of the digits of the number {0} is {1}", n, Sum_Number(n));
    }
}