using ConsoleApp7;
using System;


class Program
{
    public static void Main(string[] args)
    {
        // int[,] new_matrix = Matris.Create();

        // Matris.Write_It(new_matrix);

        // int[,] X = Matris.Null_Matrix(3, 3);

        // Matris.Write_It(X);

        /*

        int[,] X = Matris.Diagonal_Matrix(5);

        Matris.Write_It(X);

        int[] array_of_elements = Matris.List_of_Diagonal_Elements(X);

        Matris.Write_It(array_of_elements);

        */

        /*
         
        int[,] X = Matris.Create(3, 2);

        Matris.Write_It(X);

        int[,] T = Matris.Tranpose(X);

        Matris.Write_It(T);
         */

        /*

        int[,] X = Matris.Create(3, 4);

        int[,] Y= Matris.Create(5, 4);

        Matris.Write_It(X);
        Matris.Write_It(Y);

        Console.WriteLine("{0}", Matris.Are_They_Equal(X, Y) ? "They are equal each other" : "They are not equal each other");
      
        */
        int[,] X = Matris.Create(2, 2);

        Matris.Write_It(X);

        Console.WriteLine("Determinant: {0}",Matris.Determinant(X));

    }
}
