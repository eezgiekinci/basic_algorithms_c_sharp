using ConsoleApp6;



using System;
public class Mathematics
{
    public static string Find_Prime_Factors(int number)
    {
        string prime_factor_list = "";

        int i = 2;

        while (number > 1)
        {
            if (number % i == 0)
            {
                number /= i;

                prime_factor_list += i.ToString() + ",";

            }

            else
                i++;

        }
        // it helps to remove last the "," 
        prime_factor_list = prime_factor_list.Substring(0, prime_factor_list.Length - 1);

        // suppose that we enter 60 as a parameter. Its prime factors are 2,2,3,5. However, we do not want two or more repeating digits.

        string[] factors = prime_factor_list.Split(',');

        string temp = factors[0];

        string result = temp;

        for (int j = 0; j < factors.Length; j++)
        {
            if (!(temp == factors[j]))
            {
                result = result + "," + factors[j];
                temp = factors[j];
            }
        }

        return result;
    }


}

// MAIN 

    class Prime_Factors
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Mathematics.Find_Prime_Factors(number));
    }

}
    
