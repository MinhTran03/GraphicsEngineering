using System;

namespace GraphicsEngineering.DataAccess.Common
{
	public class MatrixTransform
	{
		// Sau khi khởi tạo sẽ gán vô ma trận để get về
		public double[,] TranslatingMatrix { get; private set; } = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
		public double[,] RotateMatrix { get; private set; } = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
		public double[,] ScaleMatrix { get; private set; } = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
		public double[,] HorizontalOppositeMatrix { get; private set; } = { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
		public double[,] VerticalOppositeMatrix { get; private set; } = { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
		public double[,] OriginCoordinatesOppositeMatrix { get; private set; } = { { -1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };

		/// <summary>
		/// Khởi tạo ma trận tịnh tiến
		/// </summary>
		/// <param name="sX"></param>
		/// <param name="sY"></param>
		public void GenerateTranslatingMatrix(int trX, int trY)
		{
			TranslatingMatrix[2, 0] = trX;
			TranslatingMatrix[2, 1] = trY;
		}
		/// <summary>
		/// Khởi tạo ma trận Rotate
		/// </summary>
		/// <param name="alpha"></param>
		public void GenerateRotateMatrix(double angle)
		{
			var temp = Math.PI * angle / 180;
			RotateMatrix[0, 0] = Math.Cos(temp);
			RotateMatrix[0, 1] = Math.Sin(temp);
			RotateMatrix[1, 0] = -RotateMatrix[0, 1];
			RotateMatrix[1, 1] = RotateMatrix[0, 0];
		}
		/// <summary>
		/// Khởi tạo ma trận Scale
		/// </summary>
		/// <param name="scaleX"></param>
		/// <param name="scaleY"></param>
		public void GenerateScaleMatrix(double scaleX, double scaleY)
		{
			ScaleMatrix[0, 0] = scaleX;
			ScaleMatrix[1, 1] = scaleY;
		}
	}
}
