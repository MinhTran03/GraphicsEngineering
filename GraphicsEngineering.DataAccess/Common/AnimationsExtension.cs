using System;
using System.Drawing;

namespace GraphicsEngineering.DataAccess.Common
{
	public static class AnimationsExtension
	{
		//public static Point Move(this Point point, int sX, int sY)
		//{
		//	point.X += sX;
		//	point.Y += sY;
		//	return point;
		//}
		//public static Point[] Move(this Point[] point, int sX, int sY)
		//{
		//	for (int i = 0; i < point.Length; i++)
		//	{
		//		point[i].X += sX;
		//		point[i].Y += sY;
		//	}
		//	return point;
		//}
		//public static Point Scale(this Point point, int sX, int sY)
		//{
		//	point.X *= sX;
		//	point.Y *= sY;
		//	return point;
		//}
		//public static Point[] Scale(this Point[] points, int sX, int sY)
		//{
		//	for (int pos = 0; pos < points.Length; pos++)
		//	{
		//		points[pos].X *= sX;
		//		points[pos].Y *= sY;
		//	}
		//	return points;
		//}
		//public static Point Opposite(this Point point, Point origin, OppositeType oppositeType)
		//{
		//	// origin có thể là điểm bất kì cũng có thể là gốc tọa độ
		//	var newPoint = point.Move(-origin.X, -origin.Y);
		//	switch(oppositeType)
		//	{
		//		case OppositeType.VerticalAxis:
		//			newPoint.X = -newPoint.X;
		//			break;
		//		case OppositeType.HorizontalAxis:
		//			newPoint.Y = -newPoint.Y;
		//			break;
		//		case OppositeType.OriginCoordinates:
		//			newPoint.X = -newPoint.X;
		//			newPoint.Y = -newPoint.Y;
		//			break;
		//	}
		//	point = origin.Move(newPoint.X, newPoint.Y);
		//	return point;
		//}
		//public static Point[] Opposite(this Point[] points, Point origin, OppositeType oppositeType)
		//{
		//	for (int i = 0; i < points.Length; i++)
		//	{
		//		var newPoint = points[i].Move(-origin.X, -origin.Y);
		//		if (oppositeType == OppositeType.VerticalAxis) newPoint.X = -newPoint.X;
		//		else if (oppositeType == OppositeType.HorizontalAxis) newPoint.Y = -newPoint.Y;
		//		else
		//		{
		//			newPoint.X = -newPoint.X;
		//			newPoint.Y = -newPoint.Y;
		//		}
		//		points[i] = origin.Move(newPoint.X, newPoint.Y);
		//	}
		//	return points;
		//}
		//public static Point Rotate(this Point point, Point origin, int alpha)
		//{
		//	var newPoint = point.Move(-origin.X, -origin.Y);
		//	double temp1 = Math.Cos(Math.PI * alpha / 180);
		//	double temp2 = Math.Sin(Math.PI * alpha / 180);
		//	double temp3 = Math.Sin(Math.PI * alpha / 180);
		//	double temp4 = Math.Cos(Math.PI * alpha / 180);
		//	int newDx = (int)Math.Round(newPoint.X * temp1 - newPoint.Y * temp2);
		//	int newDy = (int)Math.Round(newPoint.X * temp3 + newPoint.Y * temp4);
		//	point = origin.Move(newDx, newDy);
		//	return point;
		//}
		//public static Point[] Rotate(this Point[] points, Point origin, int alpha)
		//{
		//	for (int i = 0; i < points.Length; i++)
		//	{
		//		var newPoint = points[i].Move(-origin.X, -origin.Y);
		//		double temp1 = Math.Cos(Math.PI * alpha / 180);
		//		double temp2 = Math.Sin(Math.PI * alpha / 180);
		//		double temp3 = Math.Sin(Math.PI * alpha / 180);
		//		double temp4 = Math.Cos(Math.PI * alpha / 180);
		//		int newDx = (int)Math.Round(newPoint.X * temp1 - newPoint.Y * temp2);
		//		int newDy = (int)Math.Round(newPoint.X * temp3 + newPoint.Y * temp4);
		//		points[i] = origin.Move(newDx, newDy);
		//	}
		//	return points;
		//}

		/// <summary>
		/// Phép biến đổi tịnh tiến dùng ma trận biến đổi
		/// </summary>
		/// <param name="point">Điểm cần tịnh tiến</param>
		/// <param name="trX">Biến đổi x</param>
		/// <param name="trY">Biến đổi y</param>
		/// <returns>Tọa độ điểm sau khi biến đổi</returns>
		public static Point Translating(this Point point, int trX, int trY)
		{
			var trans = new MatrixTransform();
			// Truyền vào trX và trY để get ma trận Move
			trans.GenerateTranslatingMatrix(trX * 5, trY * 5);
			double[,] matrixOfPoint = point.ToMatrix();
			// Thực hiện nhân với ma trận move
			double[,] resultMatrix = matrixOfPoint.MultiplicationWithMatrix(trans.TranslatingMatrix);
			// Trả về tọa độ điểm mới
			return resultMatrix.ToPoint();
		}
		/// <summary>
		/// Biến đổi Rotate trường hợp tổng quát (quay quanh 1 điểm bất kỳ)
		/// </summary>
		/// <param name="point">Điểm cần quay</param>
		/// <param name="origin">Gốc tọa độ (0, 0) hoặc điểm bất kỳ</param>
		/// <param name="alpha">Góc quay</param>
		/// <returns>Tọa độ điểm sau khi Rotate quanh 1 điểm bất kỳ</returns>
		public static Point Rotate(this Point point, Point origin, int angle)
		{
			var trans = new MatrixTransform();
			// Tạo ma trận move về gốc tọa độ
			trans.GenerateTranslatingMatrix(-origin.X, -origin.Y);
			// Tạo ma trận rotate
			trans.GenerateRotateMatrix(angle);
			double[,] matrixOfPoint = point.ToMatrix();
			// Tịnh tiến về Origin(0, 0) và thực hiện Rotate
			double[,] resultMatrix = matrixOfPoint.MultiplicationWithMatrix(trans.TranslatingMatrix)
												  .MultiplicationWithMatrix(trans.RotateMatrix);
			// Tạo ma trận move về tọa độ ban đầu
			trans.GenerateTranslatingMatrix(origin.X, origin.Y);
			// Thực hiện biến đổi
			resultMatrix = resultMatrix.MultiplicationWithMatrix(trans.TranslatingMatrix);
			// Trả về tọa độ điểm mới
			return resultMatrix.Round5().ToPoint();
		}
		/// <summary>
		/// Thực hiện đối xứng qua 1 điểm bất kỳ
		/// </summary>
		/// <param name="point">Điểm cần đối xứng</param>
		/// <param name="origin">Điểm chọn làm tâm đối xứng</param>
		/// <param name="oppositeType">Kiểu đối xứng</param>
		/// <returns>Tọa độ điểm sau khi đối xứng</returns>
		public static Point Opposite(this Point point, Point origin, OppositeType oppositeType)
		{
			var trans = new MatrixTransform();
			// Tạo ma trận move về gốc tọa độ
			trans.GenerateTranslatingMatrix(-origin.X, -origin.Y);
			double[,] matrixOfPoint = point.ToMatrix();
			double[,] oppositeMatrix;
			// Get opposite matrix
			switch(oppositeType)
			{
				case OppositeType.HorizontalAxis:
					oppositeMatrix = trans.HorizontalOppositeMatrix;
					break;
				case OppositeType.VerticalAxis:
					oppositeMatrix = trans.VerticalOppositeMatrix;
					break;
				default:
					oppositeMatrix = trans.OriginCoordinatesOppositeMatrix;
					break;
			}
			double[,] resultMatrix = matrixOfPoint.MultiplicationWithMatrix(trans.TranslatingMatrix)
												  .MultiplicationWithMatrix(oppositeMatrix);
			// Tạo ma trận move về tọa độ ban đầu
			trans.GenerateTranslatingMatrix(origin.X, origin.Y);
			// Thực hiện biến đổi
			resultMatrix = resultMatrix.MultiplicationWithMatrix(trans.TranslatingMatrix);
			// Trả về tọa độ điểm mới
			return resultMatrix.ToPoint();
		}
		/// <summary>
		/// Thực hiện scale 1 điểm theo tâm scale
		/// </summary>
		/// <param name="point">Điểm cần scale</param>
		/// <param name="origin">Tâm scale</param>
		/// <param name="scaleX">Tỷ lệ theo trục hoành</param>
		/// <param name="scaleY">Tỷ lệ theo trục tung</param>
		/// <returns>Tọa độ điểm sau khi scale</returns>
		public static Point Scale(this Point point, Point origin, double scaleX, double scaleY)
		{
			var trans = new MatrixTransform();
			// Tạo ma trận move về gốc tọa độ
			trans.GenerateTranslatingMatrix(-origin.X, -origin.Y);
			// Tạo ma trận scale
			trans.GenerateScaleMatrix(scaleX, scaleY);
			double[,] matrixOfPoint = point.ToMatrix();
			double[,] resultMatrix = matrixOfPoint.MultiplicationWithMatrix(trans.TranslatingMatrix)
												  .MultiplicationWithMatrix(trans.ScaleMatrix);
			// Tạo ma trận move về tọa độ ban đầu
			trans.GenerateTranslatingMatrix(origin.X, origin.Y);
			// Thực hiện biến đổi
			resultMatrix = resultMatrix.MultiplicationWithMatrix(trans.TranslatingMatrix);
			// Trả về tọa độ điểm mới
			return resultMatrix.ToPoint();
		}

		/// <summary>
		/// Chuyển tọa độ điểm thành ma trận 1x3
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		private static double[,] ToMatrix(this Point point)
		{
			return new double[,] { { point.X, point.Y, 1 } };
		}
		/// <summary>
		/// Chuyển ma trận 1x3 thành điểm
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns></returns>
		private static Point ToPoint(this double[,] matrix)
		{
			return new Point() { X = (int)matrix[0, 0], Y = (int)matrix[0, 1] };
		}
	}
}
