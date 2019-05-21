using GraphicsEngineering.DataAccess.Common;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEngineering.DataAccess.Models
{
	public class MyRectangle : Shape
	{
		public Point A { get; set; }
		public Point B { get; set; }
		public Point C { get; set; }
		public Point D { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
		private List<Line> lines { get; set; }

		public MyRectangle(Rectangle rect) : this(rect, Color.Black) { }
		public MyRectangle(Rectangle rect, Color color)
			: base(rect, color)
		{
			lines = new List<Line>();
			OnChangedRegionValue();
			Width = Math.Abs(B.X - A.X);
			Height = Math.Abs(D.Y - A.Y);
		}

		/// <summary>
		/// Update lại giá trị đỉnh ABCD Width Height sau khi Region bị thay đổi
		/// </summary>
		private void OnChangedRegionValue()
		{
			//code chỗ này hơi ngu => sửa sau
			A = new Point(Region.X, Region.Y);
			B = new Point(Region.X + Region.Width, Region.Y);
			C = new Point(Region.X + Region.Width, Region.Y + Region.Height);
			D = new Point(Region.X, Region.Y + Region.Height);
			// Khi new 1 line thì Begin và End truyền vô sẽ được chuyển sang tọa độ máy
			// mà ABCD đã là tọa độ máy => cần chuyển về tọa độ ng dùng
			Point worldA = A.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldB = B.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldC = C.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldD = D.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			lines.Clear();
			lines.Add(new Line(worldA, worldB, Color));
			lines.Add(new Line(worldA, worldD, Color));
			lines.Add(new Line(worldD, worldC, Color));
			lines.Add(new Line(worldB, worldC, Color));
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			foreach (var line in lines)
			{
				line.Draw(graphics, dashes);
			}
		}
		public override string ToString()
		{
			double worldWidth = Width / 5;
			double worldHeight = Height / 5;
			Point worldKernel = Kernel.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldA = A.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldB = B.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldC = C.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldD = D.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);

			return $"Rectangle:\n" +
					$"      + A: {worldA.ToString()} \n" +
					$"      + B: {worldB.ToString()} \n" +
					$"      + C: {worldC.ToString()} \n" +
					$"      + D: {worldD.ToString()} \n" +
					$"      + Width: {worldWidth.ToString()} \n" +
					$"      + Height: {worldHeight.ToString()} \n" +
					$"      + Kernel: {worldKernel.ToString()} \n";
		}

		/// <summary>
		/// Work on world coordinate
		/// </summary>
		/// <param name="point1">world Origin Point</param>
		/// <param name="point2">world Fixed Point</param>
		//public void FixRotateLength(Point point1, Point point2, int distance)
		//{
		//	int dx = Math.Abs(point1.X - point2.X);
		//	int dy = Math.Abs(point1.Y - point2.Y);
		//	if(dx == 0)
		//	{
		//		point2.X += distance;
		//	}
		//	else if(dy == 0)
		//	{
		//		point2.Y += distance;
		//	}
		//	else
		//	{

		//	}
		//}

		public override void TranslatingTransform(int trX, int trY)
		{
			Region.Location = Region.Location.Translating(trX, trY);
			Kernel = Kernel.Translating(trX, trY);

			A = A.Translating(trX, trY);
			B = B.Translating(trX, trY);
			C = C.Translating(trX, trY);
			D = D.Translating(trX, trY);
			Point worldA = A.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldB = B.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldC = C.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldD = D.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			lines.Clear();
			lines.Add(new Line(worldA, worldB, Color));
			lines.Add(new Line(worldA, worldD, Color));
			lines.Add(new Line(worldD, worldC, Color));
			lines.Add(new Line(worldB, worldC, Color));
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			Width *= scaleX;
			Height *= scaleY;
			A = A.Scale(origin, scaleX, scaleY);
			Kernel = Kernel.Scale(origin, scaleX, scaleY);
			Region = new Rectangle(A, new Size((int)Width, (int)Height));
			OnChangedRegionValue();
		}
		public override void RotateTransform(Point origin, int angle)
		{
			Region.Location = Region.Location.Rotate(origin, angle);
			Kernel = Kernel.Rotate(origin, angle);

			A = A.Rotate(origin, angle);
			B = B.Rotate(origin, angle);
			C = C.Rotate(origin, angle);
			D = D.Rotate(origin, angle);
			Point worldA = A.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldB = B.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldC = C.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Point worldD = D.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);

			//double distanceAC = Math.Round(Math.Sqrt(Math.Pow(worldA.X - worldC.X, 2) + Math.Pow(worldA.Y - worldC.Y, 2)));
			//double realDistance = Math.Round(Math.Sqrt(Height/5 * Height/5 + Width/5 * Width/5));
			//if (distanceAC != realDistance)
			//{

			//}

			lines.Clear();
			lines.Add(new Line(worldA, worldB, Color));
			lines.Add(new Line(worldA, worldD, Color));
			lines.Add(new Line(worldD, worldC, Color));
			lines.Add(new Line(worldB, worldC, Color));
		}
		public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			Kernel = Kernel.Opposite(origin, oppositeType);
			Region.Location = new Point()
			{
				X = Kernel.X - (Region.Width / 2).Round5(),
				Y = Kernel.Y - (Region.Height / 2).Round5(),
			};
			OnChangedRegionValue();
		}
	}
}
