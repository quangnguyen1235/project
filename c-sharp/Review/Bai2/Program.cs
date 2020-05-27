using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input Row of matrix 1: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("input Col of matrix 1: ");
            int col1 = int.Parse(Console.ReadLine());
            IntMatrix matrix1 = new IntMatrix(row1, col1);
            matrix1.matrix = matrix1.CreateMatrix();
            Console.WriteLine(matrix1.ToString());


            Console.Write("input Row of matrix 2: ");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("input Col of matrix 2: ");
            int col2 = int.Parse(Console.ReadLine());
            IntMatrix matrix2 = new IntMatrix(row2, col2);
            matrix2.matrix = matrix2.CreateMatrix();
            Console.WriteLine(matrix2.ToString());


            if(matrix1.col == matrix2.row)
            {
                Console.WriteLine(Helper.CreateMutipleMatrix(matrix1, matrix2).ToString());
            }
            else
            {
                Console.WriteLine("Can't Calculate");
            }
        }
    }
}
