using System;

namespace FinalModul2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Matrix newMatrix = new Matrix(3, 4);
            newMatrix.InitMatrix();
            newMatrix.ShowMatrix(newMatrix.matrix);
        }
       
    }
}
