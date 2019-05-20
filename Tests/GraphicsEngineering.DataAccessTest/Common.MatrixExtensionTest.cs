using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccessTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void MultiplicationMatrixTest()
		{
			int[,] matrix1 = new int[,] { { 3, 4 } };
			int[,] matrix2 = new int[,] { { 1, 2 }, { 2, 1 } };

			int[,] expected = new int[,] { { 11, 10 } };

			int[,] actual = matrix1.MultiplicationToMatrix(matrix2);

			for (int i = 0; i < matrix1.GetLength(0); i++)
			{
				for (int j = 0; j < matrix2.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], actual[i, j]);
				}
			}
		}
	}
}
