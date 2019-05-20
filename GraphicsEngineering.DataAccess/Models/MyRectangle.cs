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
			Point worldA = A.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldB = B.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldC = C.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldD = D.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			lines.Clear();
			lines.Add(new Line(worldA, worldB));
			lines.Add(new Line(worldA, worldD));
			lines.Add(new Line(worldD, worldC));
			lines.Add(new Line(worldB, worldC));
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
			Point worldKernel = Kernel.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldA = A.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldB = B.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldC = C.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldD = D.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);

			return $"Rectangle:\n" +
					$"A: {worldA.ToString()} \n" +
					$"B: {worldB.ToString()} \n" +
					$"C: {worldC.ToString()} \n" +
					$"D: {worldD.ToString()} \n" +
					$"Width: {worldWidth.ToString()} \n" +
					$"Height: {worldHeight.ToString()} \n" +
					$"Kernel: {worldKernel.ToString()} \n";
		}

		public override void TranslatingTransform(int trX, int trY)
		{
			Region.Location = Region.Location.Translating(trX, trY);
			Kernel = Kernel.Translating(trX, trY);

			A = A.Translating(trX, trY);
			B = B.Translating(trX, trY);
			C = C.Translating(trX, trY);
			D = D.Translating(trX, trY);
			Point worldA = A.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldB = B.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldC = C.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldD = D.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			lines.Clear();
			lines.Add(new Line(worldA, worldB));
			lines.Add(new Line(worldA, worldD));
			lines.Add(new Line(worldD, worldC));
			lines.Add(new Line(worldB, worldC));
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
			Point worldA = A.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldB = B.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldC = C.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldD = D.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			lines.Clear();
			lines.Add(new Line(worldA, worldB));
			lines.Add(new Line(worldA, worldD));
			lines.Add(new Line(worldD, worldC));
			lines.Add(new Line(worldB, worldC));
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
