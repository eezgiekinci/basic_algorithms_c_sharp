// It finds the standard deviation of randomly given values.

// It finds all odd and even values ​​in an array. Assigns either odd_array or even_array, depending on whether the value is odd or even.


using System;
using System.Collections;

class Odd_Even_Arrays

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


        // find even and odd values:

        ArrayList even_array = new ArrayList();

        ArrayList odd_array = new ArrayList();
        

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] %2 == 0)
                even_array.Add(numbers[i]);

            else
                odd_array.Add(numbers[i]);
        }
        Console.Write("\nEven Array: ");

        foreach(int i in even_array)
            Console.Write("{0} ", i);

        Console.Write("\nOdd Array: ");

        foreach (int i in odd_array)
            Console.Write("{0} ", i);
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter array's length: ");
        int array_length = Convert.ToInt32(Console.ReadLine());

        Create_Array(array_length);


    }
}