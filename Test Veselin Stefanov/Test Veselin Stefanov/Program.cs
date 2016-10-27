using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the size for one side of your array");
            int size = int.Parse(Console.ReadLine());

            if (size < 2 || size > 9)
            {
                Console.WriteLine("Your value is worng.");

            }
            else
            {
                Console.WriteLine("Your value is accepted and is {0}", size);

                int[,] matrix = new int[size, size];
                int[] array = new int[matrix.Length];


                for (int i = 0; i < array.Length; i++)
                {

                    Console.WriteLine("Enter value in slot {0} for the array", i + 1);
                    array[i] = int.Parse(Console.ReadLine());


                }


                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = array[i] + sum;

                }

               

                Console.WriteLine("The sum of the numbers you have submmited is : {0}", sum);
                Console.ReadKey();


                int counter = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[col, row] = array[counter];
                        counter++;
                    }
                }

                Console.WriteLine("\n\n When we enter the values in the matrix from the array vertically... \n Your matrix becomes: \n");

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(string.Format("\t|{0}| ", matrix[row, col]));

                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }

            }







        }
    }
}

