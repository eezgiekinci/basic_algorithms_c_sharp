
// It returns the minimum and the maximum value in a array. 
// The elements of the array are randomly assigned from 0 to 100. 

using System;

class Array_Min_Max
{
    public static void Min_Max(int array_length)
    {
        int[] numbers = new int[array_length];
       
        int min = 0, max = 0;

        Random random_element = new Random();

        //elements of array:

        for (int i=0; i<array_length; i++)
        {
            numbers[i] = random_element.Next(0,100);
        }


        foreach(int i in numbers)
        {
            Console.Write("{0} ",i);
        }

        // min and max:

         min = numbers[0];

        for(int i = 0; i<numbers.Length; i++)
        {
            if (numbers[i] >= max)
                max = numbers[i];

            if (numbers[i] <= min)
                min = numbers[i];
        }


        Console.WriteLine("\nMin: {0} ", min);
        Console.WriteLine("Max: {0} ", max);
        
        
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter array's length: ");
        int array_length = Convert.ToInt32(Console.ReadLine());
        Min_Max(array_length);
     
    }
}