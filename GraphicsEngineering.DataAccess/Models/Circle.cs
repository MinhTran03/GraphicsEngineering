using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public class Circle : Shape
	{
		public double Radius { get; set; }

		public Circle(Rectangle rect)
			: this(rect, Color.Black) { }
		public Circle(Rectangle rect, Color color)
			: base(rect, color)
		{
			Radius = (Region.Width / 2).Round5();
		}

		private void Put8PixelCircle(Color color, Point kernel, int x, int y)
		{
			PutPixel(color, kernel.X + x, kernel.Y + y);
			PutPixel(color, kernel.X + y, kernel.Y + x);
			PutPixel(color, kernel.X + y, kernel.Y - x);
			PutPixel(color, kernel.X + x, kernel.Y - y);
			PutPixel(color, kernel.X - x, kernel.Y - y);
			PutPixel(color, kernel.X - y, kernel.Y - x);
			PutPixel(color, kernel.X - y, kernel.Y + x);
			PutPixel(color, kernel.X - x, kernel.Y + y);
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			base.Graphics = graphics;

			int x, y;
			var R = Region.Width / 2;
			var kernel = new Point(Region.X + R, Region.Y + R);
			kernel.X = kernel.X.Round5();
			kernel.Y = kernel.Y.Round5();

			x = 0;
			y = R;
			Put8PixelCircle(Color, kernel, x, y.Round5());
			long p = 1 - R; // 5/4-R
			while (x < y)
			{
				if (p < 0)
					p += 2 * x + 3;
				else
				{
					p += 2 * (x - y) + 5;
					y--;
				}
				x++;
				// Round y lại để tránh y % 5 != 0
				if (x % 5 == 0) Put8PixelCircle(Color, kernel, x, y.Round5());
			}
		}
		public override string ToString()
		{
			Point worldKernel = Kernel.ToWorldCoordinates();
			return $"Circle \n" +
				$"\t      + Kernel: {worldKernel.ToString()} \n" +
				$"\t      + Radius: {(Radius / 5).ToString()} \n";
		}

		public override void TranslatingTransform(int trX, int trY)
		{
			Region.Location = Region.Location.Translating(trX, trY);
			Kernel = Kernel.Translating(trX, trY);
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			Radius *= scaleX;
			Kernel = Kernel.Scale(origin, scaleX, scaleY);
			Point A = new Point(Kernel.X - (int)Radius, Kernel.Y - (int)Radius);
			Region = new Rectangle(A, new Size((int)Radius * 2, (int)Radius * 2));
		}
		public override void RotateTransform(Point origin, int angle)
		{
			// Quay tâm ellipse, ko phải quay góc trái
			// sai
			Kernel = Kernel.Rotate(origin, angle);
			Region.Location = new Point()
			{
				X = Kernel.X - (Region.Width / 2).Round5(),
				Y = Kernel.Y - (Region.Height / 2).Round5(),
			};
		}
		public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			Kernel = Kernel.Opposite(origin, oppositeType);
			Region.Location = new Point()
			{
				X = Kernel.X - (Region.Width / 2).Round5(),
				Y = Kernel.Y - (Region.Height / 2).Round5(),
			};
		}
	}
}
