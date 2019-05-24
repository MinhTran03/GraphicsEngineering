using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public class Ellipse : Shape
	{
		public double RadiusA { get; set; }
		public double RadiusB { get; set; }

		public Ellipse(Rectangle rect)
			: this(rect, Color.Black) { }
		public Ellipse(Rectangle rect, Color color)
			: base(rect, color)
		{
			RadiusA = (Region.Width / 2).Round5();
			RadiusB = (Region.Height / 2).Round5();
		}

		private void Put4PixelsEllipse(Color color, Point kernel, int x, int y)
		{
			PutPixel(color, kernel.X + x, kernel.Y - y);
			PutPixel(color, kernel.X + x, kernel.Y + y);
			PutPixel(color, kernel.X - x, kernel.Y + y);
			PutPixel(color, kernel.X - x, kernel.Y - y);
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			base.Graphics = graphics;

			int a = Region.Width / 2;
			int b = Region.Height / 2;
			Point kernel = new Point(Region.X + a, Region.Y + b);
			kernel.X = kernel.X.Round5();
			kernel.Y = kernel.Y.Round5();

			int x = 0;
			int y = b;
			long a2 = a * a;
			long b2 = b * b;
			long fx = 0;
			long fy = 2 * a2 * y;
			double p = b2 - (a2 * b) + (a2 / 4); //đây là P0(0, b) => f(1, b-1/2)
			Put4PixelsEllipse(Color, kernel, x, y.Round5());
			while (fx < fy)
			{
				x++;
				fx += 2 * b2;
				if (p < 0)
					p += b2 + fx;
				else
				{
					y--;
					fy -= 2 * a2;
					p += b2 + fx - fy;
				}
				// x chạy => kiểm tra x % 5 && round(y) để y chia hết cho 5
				if (x % 5 == 0) Put4PixelsEllipse(Color, kernel, x, y.Round5());
			}
			p = Math.Round(b2 * (x + 0.5f) * (x + 0.5f) + a2 * (y - 1) * (y - 1) - a2 * b2);
			while (y > 0)
			{
				y--;
				fy -= a2 * 2;
				if (p > 0)
					p += a2 - fy;
				else
				{
					x++;
					fx += b2 * 2;
					p += a2 - fy + fx;
				}
				// y chạy => kiểm tra y % 5 && round(x) để x chia hết cho 5
				if (y % 5 == 0) Put4PixelsEllipse(Color, kernel, x.Round5(), y);
			}
		}
		public override string ToString()
		{
			Point worldKernel = Kernel.ToWorldCoordinates();
			return $"Ellipse: \r\n" +
				$"\t + Kernel: {worldKernel.ToString()} \r\n" +
				$"\t + Radius A: {(RadiusA / 5).ToString()} \r\n" +
				$"\t + Radius B: {(RadiusB / 5).ToString()} \r\n";
		}

		// Khi chạy hiệu ứng cần update lại Region, Kernel, [Radius]
		public override void TranslatingTransform(int trX, int trY)
		{
			Region.Location = Region.Location.Translating(trX, trY);
			Kernel = Kernel.Translating(trX, trY);
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			RadiusA *= scaleX;
			RadiusB *= scaleY;
			Kernel = Kernel.Scale(origin, scaleX, scaleY);
			Point A = new Point(Kernel.X - (int)RadiusA, Kernel.Y - (int)RadiusB);
			Region = new Rectangle(A, new Size((int)RadiusA * 2, (int)RadiusB * 2));
		}
		public override void RotateTransform(Point origin, int angle)
		{
			// Quay tâm ellipse, ko phải quay góc trái 
			// cái này sai
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
