
// It finds the standard deviation of randomly given values.


using System;

class Standart_Deviation

{
    // The elements of the array are randomly assigned from 0 to 100:
    public static void Create_Array(int array_length)
    {
        int[] numbers = new int[array_length];

        Random random_element = new Random();

        //elements of array:

        for (int i = 0; i < array_length; i++)
        {
            numbers[i] = random_element.Next(0, 100);
        }


        foreach (int i in numbers)
        {
            Console.Write("{0} ", i);
        }

       
    }

    // In order to calculate the standard deviation, we must first find the arithmetic mean of the given values:
    public static int Arithmetic_Mean(int[] numbers)
    {
        int sum = 0, arithmetic_mean = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }

        arithmetic_mean = sum / numbers.Length;
        
        return arithmetic_mean;
    }

    // Standart Deviation:
    public static double S_Deviation (int[] numbers)
    {
        double temp = 0, s_deviation = 0;
        double d = 0, sum = 0;

        double arithmetic_mean = Arithmetic_Mean(numbers)

        for(int i = 0; i < numbers.Length;i++)
        {
            temp = (numbers[i] - arithmetic_mean);
            d = Math.Pow(temp, 2);
            sum += d;
        }

        s_deviation = (int)Math.Sqrt(sum / numbers.Length);

        return s_deviation;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter array's length: ");
        int array_length = Convert.ToInt32(Console.ReadLine());

        Create_Array(array_length);

        Arithmetic_Mean(numbers);

        S_Deviation(numbers);

    }
}