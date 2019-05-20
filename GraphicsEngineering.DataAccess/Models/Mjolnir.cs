using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			var beginHelve = new Point(rect.X + rect.Width / 2, rect.Y - rect.Height / 3);
			var endHelve = new Point(rect.X + rect.Width / 2, rect.Y - rect.Height);
			bodyRect.Height /= 3;
			Body = new MyRectangle(bodyRect, color);
			Helve = new Line(beginHelve, endHelve);
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			Body.Draw(graphics, dashes);
			Helve.Draw(graphics, dashes);
		}

		public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			throw new NotImplementedException();
		}
		public override void RotateTransform(Point origin, int angle)
		{
			Body.RotateTransform(origin, angle);
			Helve.RotateTransform(origin, angle);
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			throw new NotImplementedException();
		}
		public override void TranslatingTransform(int trX, int trY)
		{
			Body.TranslatingTransform(trX, trY);
			Helve.TranslatingTransform(trX, trY);
		}
	}
}
