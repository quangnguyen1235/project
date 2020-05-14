using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace MatrixDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = @"C:\Users\Admin\Documents\project\project\c-sharp\MatrixDemo\MatrixDemo\Files\input.txt";
            string pathOutput = @"C:\Users\Admin\Documents\project\project\c-sharp\MatrixDemo\MatrixDemo\Files\output.txt";
            int[,] matrix;
            int[,] matrix3;
            int row, col;
            using (StreamReader sr = File.OpenText(pathInput))
            {
                string line = "";
                line = sr.ReadLine();
                string[] rowCol = line.Split(" ");
                row = int.Parse(rowCol[0]);
                col = int.Parse(rowCol[1]);
                matrix = new int[row, col];
                matrix3 = new int[row, col];
                int rowIndex = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    for (int i = 0; i < rows.Length; i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i]);
                        matrix3[rowIndex, i] = int.Parse(rows[i])*3;
                    }
                    rowIndex++;
                }
            }
            using (StreamWriter sw = File.CreateText(pathOutput))
            {
                sw.WriteLine($"Sum matrix: {Matrix.SumOfMatrix(matrix)}\nQlt of Prime: {Matrix.NumofPrime(matrix)}\nQlt of OldNumber: {Matrix.NumofOld(matrix)}\nSum of Digonal: {Matrix.SumofDigonal(row, col, matrix)}");
                sw.WriteLine($"{row} {col}");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sw.Write($"{matrix3 [i, j]}\t");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
