using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEngineering.DataAccess.Common
{
	public static class CommonExtensions
	{
		/// <summary>
		/// Làm tròn thành tọa độ 5px
		/// </summary>
		/// <param name="value"></param>
		/// <returns>Tọa độ đã đc làm tròn</returns>
		public static int Round5(this int value)
		{
			int newValue;
			double sodu = value % 5;
			if (sodu != 0)
			{
				if (sodu >= 3) newValue = (int)(value + 5 - sodu);
				else newValue = (int)(value - sodu);
			}
			else newValue = value;
			return newValue;
		}

		public static double[,] Round5(this double[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = Convert.ToInt32(Math.Round(matrix[i, j])).Round5();
				}
			}
			return matrix;
		}

		public static Point ToWorldCoordinates(this Point computerCoordinates)
		{
			int width = Cons.WIDTH;
			int height = Cons.HEIGHT;
			return new Point((computerCoordinates.X - (width / 2)) / 5, 
							((height / 2) - computerCoordinates.Y) / 5);
		}

		public static Point ToComputerCoordinates(this Point worldCoordinates)
		{
			int width = Cons.WIDTH;
			int height = Cons.HEIGHT;
			return new Point(worldCoordinates.X * 5 + (width / 2), 
							(height / 2) - worldCoordinates.Y * 5);
		}

		public static Rectangle ToWorldRectangle(this Rectangle computerRectangle)
		{
			int width = Cons.WIDTH;
			int height = Cons.HEIGHT;
			computerRectangle.Width /= 5;
			computerRectangle.Height /= 5;
			computerRectangle.Location = computerRectangle.Location.ToWorldCoordinates();
			return computerRectangle;
		}
	}
}
