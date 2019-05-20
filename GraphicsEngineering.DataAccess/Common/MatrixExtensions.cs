using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEngineering.DataAccess.Common
{
	public static class MatrixExtension
	{
		/// <summary>
		/// Nhân 2 ma trận matrix1 và matrix2
		/// </summary>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns>Ma trận sau khi nhân</returns>
		public static double[,] MultiplicationWithMatrix(this double[,] matrix1, double[,] matrix2)
		{
			int rowOfMatrix1 = matrix1.GetLength(0);
			int colOfMatrix1 = matrix1.GetLength(1);
			int rowOfMatrix2 = matrix2.GetLength(0);
			int colOfMatrix2 = matrix2.GetLength(1);

			int rowResultMatrix = rowOfMatrix1;
			int colResultMatrix = colOfMatrix2;
			double[,] resultMatrix = new double[rowResultMatrix, colResultMatrix];

			double sum;
			for (int row = 0; row < rowResultMatrix; row++)
			{
				for (int col = 0; col < colResultMatrix; col++)
				{
					sum = 0;
					for (int k = 0; k < colOfMatrix1; k++)
					{
						sum += matrix1[row, k] * matrix2[k, col];
					}
					resultMatrix[row, col] = sum;
				}
			}

			return resultMatrix;
		}
	}
}
