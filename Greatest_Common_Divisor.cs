
using System;
public class Mathematics
{
    public static int GCD(int number1, int number2)
    {
        int result = 1;
        int divider = 2;

        while (number1 != 1 && number2 != 1)
        {
            // Parameters will be given by user.
            // So, we can not know which parameter is bigger than other:
            for (int i = 2; i < (number1 > number2 ? number1 : number2); i++)
            {
                if (number1 % divider == 0 || number2 % divider == 0)
                {
                    if (number1 % divider == 0 && number2 % divider == 0)
                        result *= divider;

                    if (number1 % divider == 0)
                        number1 /= divider;

                    if (number2 % divider == 0)
                        number2 /= divider;
                }

                else
                    divider++;
            }
        }
        return result;
    }


}


    // MAIN 

    class Greatest_Common_Divisor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("Enter a number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Greatest Common Divisor({0} {1}) = {2}",
            number1, number2, Mathematics.GCD(number1, number2));
    }

}
    
