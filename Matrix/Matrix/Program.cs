using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoose = 0;

            Console.WriteLine("#### Welcome to Matrix ####");
            
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("| Please choose the exercise that you want see:    |");
            Console.WriteLine("| 1 - Exercise 1 - Main Diagonal                   |");
            Console.WriteLine("| 2 - Exercise 2 - Search Number                   |");
            Console.WriteLine("| 3 - Sair                                         |");
            Console.WriteLine("|--------------------------------------------------|");
            iChoose = int.Parse(Console.ReadLine());

            if(iChoose == 1)
            {
                MatrixExerciseOn1();
            }
            else if(iChoose == 2)
            {
                MatrixExerciseOn2();
            }
            else if(iChoose == 3)
            {
                Console.WriteLine("Thank You!");
            }
            else
            {
                Console.WriteLine("Invalid option! Please choose one of numbers above!");
            }
        }

        public static void MatrixExerciseOn1()
        {
            int iNumMatrix = 0;
            int iNum = 0;
            int iRow = 0;
            int iCol = 0;
            int iNegativeNums = 0;

            int[,] matrix = null;

            String sNumDiagonal = "";

            Console.WriteLine("#### Welcome to the Exercise 1 ####");

            Console.Write("How many numbers should the matrix have? ");
            iNumMatrix = int.Parse(Console.ReadLine());

            if (iNumMatrix > 0)
            {
                matrix = new int[iNumMatrix, iNumMatrix];
                /*
                 * Minha Solucao - INICIO
                 */
                /*
               for (int i = 0; i < matrix.Length; i++)
               {
                   Console.Write("Enter the number "+(i+1)+": ");
                   iNum = int.Parse(Console.ReadLine());

                   matrix[iRow, iCol] = iNum;

                   iCol += 1;

                   if(iCol == iNumMatrix)
                   {
                       iCol = 0;
                       iRow += 1;
                   }
               }
               */
                /*
                 * Minha Solucao - FIM
                 */

                /*
                 * Solucao do professor - INICIO
                 */
                for (int i = 0; i < iNumMatrix; i++)
                {
                    Console.WriteLine("Enter with " + iNumMatrix + " numbers split by ','");
                    string[] values = Console.ReadLine().Split(',');

                    for (int j = 0; j < iNumMatrix; j++)
                    {
                        matrix[i, j] = int.Parse(values[j]);
                    }
                }
                /*
                 * Solucao do professor - FIM
                 */

                Console.WriteLine("Matrix de Saida");

                iRow = 0;
                iCol = 0;

                Console.WriteLine("Main Diagonal: ");
                for (int i = 0; i < iNumMatrix; i++)
                {
                    Console.Write(matrix[i, i] + " ");
                }

                Console.WriteLine();

                for (int i = 0; i < iNumMatrix; i++)
                {
                    for (int j = 0; j < iNumMatrix; j++)
                    {
                        if (matrix[i, j] < 0)
                        {
                            iNegativeNums++;
                        }
                    }
                }

                Console.WriteLine("Negative numbers: " + iNegativeNums);
            }
            else
            {
                Console.WriteLine("The Matrix could not have the zero size!");
            }
        }

        public static void MatrixExerciseOn2()
        {
            int iRow = 0;
            int iCol = 0;
            int iNumSearch = 0;

            int[,] matrix = null;

            Console.WriteLine("#### Welcome to the Exercise 2 ####");

            Console.Write("How many rows should the matrix have? ");
            iRow = int.Parse(Console.ReadLine());

            Console.Write("How many columns should the matrix have? ");
            iCol = int.Parse(Console.ReadLine());

            if (iRow <= 0 || iCol <= 0)
            {
                Console.WriteLine("The Matrix could not have the zero size!");
            }
            else
            {
                matrix = new int[iRow, iCol];

                for (int i = 0; i < iRow; i++)
                {
                    Console.WriteLine("Enter with " + iCol + " numbers split by ','");
                    string[] values = Console.ReadLine().Split(',');

                    for (int j = 0; j < iCol; j++)
                    {
                        matrix[i, j] = int.Parse(values[j]);
                    }
                }

                Console.Write("Enter with the number to search: ");
                iNumSearch = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                for (int i = 0; i < iRow; i++)
                {
                    for (int j = 0; j < iCol; j++)
                    {
                        if (matrix[i, j] == iNumSearch)
                        {
                            Console.WriteLine("Position "+i+", "+j+":");

                            if (j > 0)
                            {
                                Console.WriteLine("Left: " + matrix[i, (j - 1)]);
                            }
                            if (i > 0)
                            {
                                Console.WriteLine("Up: "+ matrix[(i-1), j]);
                            }
                            if (i < (iRow-1))
                            {
                                Console.WriteLine("Down: "+ matrix[(i+1), j]);
                            }
                            if (j < (iCol-1))
                            {
                                Console.WriteLine("Right: "+ matrix[i, (j+1)]);
                            }
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }
}