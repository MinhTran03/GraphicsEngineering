using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.Draw3D
{
	public static class CommonExtensions
	{
		public static Point To2DCoordinates(this Point3D point3D)
		{
			var point2D = new Point();
           //khử hệ tọa độ theo trục y
            point2D.X = point3D.X - (int)Math.Round(point3D.Y * (Math.Sqrt(2) / 2));
            point2D.Y = point3D.Z - (int)Math.Round(point3D.Y * (Math.Sqrt(2) / 2));
            return point2D;
		}
	}
}
