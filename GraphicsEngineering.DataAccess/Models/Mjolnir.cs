using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public class Mjolnir : Shape
	{
		public MyRectangle Body { get; set; }
		public Line Helve { get; set; }

		public Mjolnir(Rectangle rect) : this(rect, Color.Black) { }
		public Mjolnir(Rectangle rect, Color color)
			: base(rect, color)
		{
			Rectangle bodyRect = rect;
			Kernel = new Point(rect.X + rect.Width / 2, rect.Y - rect.Height / 2)
									.ToComputerCoordinates(Cons.WIDTH, Cons.HEIGHT);
			var beginHelve = new Point(rect.X + rect.Width / 2, rect.Y - rect.Height / 3);
			var endHelve = new Point(rect.X + rect.Width / 2, rect.Y - rect.Height);
			bodyRect.Height /= 3;
			Body = new MyRectangle(bodyRect, color);
			Helve = new Line(beginHelve, endHelve, color);
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			Body.Draw(graphics, dashes);
			Helve.Draw(graphics, dashes);
		}
		public override string ToString()
		{
			return 
				$"> Mjolnir: \n" +
				$"   - {Body.ToString()}" +
				$"   - {Helve.ToString()}";
		}

		public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			throw new NotImplementedException();
		}
		public override void RotateTransform(Point origin, int angle)
		{
			Body.RotateTransform(origin, angle);
			Helve.RotateTransform(origin, angle);
			Kernel = Kernel.Rotate(origin, angle);
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			throw new NotImplementedException();
		}
		public override void TranslatingTransform(int trX, int trY)
		{
			Body.TranslatingTransform(trX, trY);
			Helve.TranslatingTransform(trX, trY);
			Kernel = Kernel.Translating(trX, trY);
		}
	}
}
