using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Matris
    {
        public static int[,] Create(int row = 3, int coloumn =3 , int min=1, int max=9)
        {
            int[,] new_matrix = new int[row, coloumn];

            for(int i = 0; i < row; i++)
            {
                for(int j= 0; j < coloumn; j++)
                {
                    new_matrix[i,j] = new Random().Next(min, max);
                }
            }

            return new_matrix;
        }

        public static void Write_It(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j= 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}",matrix[i,j]);
                }

                Console.WriteLine();
                
            }
            Console.WriteLine("********");
        }

        public static void Write_It(int[] X)
        {
            Console.WriteLine("********");
            for(int i = 0; i < X.Length;i++)
            {
                Console.Write("{0,5}", X[i]);
            }
            Console.WriteLine();
        }

        public static int[,] Null_Matrix (int row, int coloumn)
        {
            return Create(row, coloumn,0,0);
        }

        public static int[,] Diagonal_Matrix(int dimension = 3, int min =1, int max =9)
        {
            int[,] X = Null_Matrix(dimension, dimension);

            for(int i = 0; i< dimension; i++)
            {
                X[i, i] = new Random().Next(min, max);
            }
            return X;
        }

        public static bool Is_It_Square_Matrix(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ? true : false;
        }
        public static int[] List_of_Diagonal_Elements(int[,] X)
        {
            if (Is_It_Square_Matrix(X))
            {
                int[] array_of_elements = new int[X.GetLength(0)];

                for(int i = 0; i< X.GetLength(1); i++)
                {
                    array_of_elements[i] = X[i, i];
                }

                return array_of_elements;
            }
            else
            {
                Console.WriteLine("It is not a square matrix.");
                return new int[1];
            }
        }

        public static int[,] Tranpose(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            
            for(int i = 0; i < T.GetLength(0); i++)
            {
                for(int j = 0; j < T.GetLength(1); j++)
                {
                    T[i,j] = X[j, i];
                }
            }

            return T;

        }

        public static bool Are_They_Equal(int[,] X, int[,] Y)
        {
            bool result = true;

            if(X.GetLength(0) == Y.GetLength(0) && X.GetLength(1) == Y.GetLength(1))
            {

                // check the equality of matrixs elements:
                for(int i = 0; i < X.GetLength(0); i++)
                {
                    for(int j=0; j<X.GetLength(1); j++)
                    {
                        if (X[i,j] != Y[i, j])
                        {
                            return false;
                            break;

                        }
                            
                    }
                }


            }

            else 
                result = false;

            return result;
        }

        public static int Determinant(int[,] X)
        {
            int d = -1;
            if (Is_It_Square_Matrix(X))
            {

                d = (X[0,0] * X[1,1]) - (X[0,1] * X[1,0]);
                return d;
            }

            else
            {
                Console.WriteLine(" Matrix's determinant cannot calculate because the matrix is not a sqaure matrix");
                return d;
            }
            
        }
    }
}
