using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IODemo
{
    class MatrixIODemo
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\input.txt";
            string pathOutput = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\output.txt";
            int[,] matrix;
            int row, col;
            using (StreamReader sr = File.OpenText(pathInput))
            {
                string line = "";
                line = sr.ReadLine();
                string[]rowCol =  line.Split(" ");
                row = int.Parse(rowCol[0]);
                col = int.Parse(rowCol[1]);
                matrix = new int[row, col];
                int rowIndex = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    for (int i = 0; i < rows.Length; i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i]) * 2;
                    }
                    rowIndex++;
                }
            }
            using (StreamWriter sw = File.CreateText(pathOutput))
            {
                sw.WriteLine($"{row} {col}");
                for (int i = 0; i < row; i++)
                { 
                    for(int j = 0; j < col; j++)
                    {
                        sw.Write($"{matrix[i, j]}\t");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
