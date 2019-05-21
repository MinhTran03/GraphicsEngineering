using System;
using System.Collections.Generic;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public class Lightning : Shape	
	{
		//public Point Begin { get; set; }
		//public Point End { get; set; }
		public Point MiddleUp { get; set; }
		public Point MiddleDown { get; set; }
		public List<Line> Lines{ get; set; }

		public Lightning(Point begin, Point end) : this(begin, end, Color.Black) { }
		public Lightning(Point begin, Point end, Color color)
			: base(begin, end, color)
		{
			Lines = new List<Line>();
			int distanceX = Math.Abs(end.X - begin.X);
			int distanceY = Math.Abs(end.Y - begin.Y);
			int middleX = (end.X <= begin.X ? end.X : begin.X) + distanceX / 2;
			Point middle = new Point(middleX, begin.Y - distanceY / 2);
			MiddleUp = new Point(distanceX / 2 + 3 + middle.X, middle.Y + 3);
			MiddleDown = new Point(distanceX / 2 - 3 + middle.X, middle.Y - 3);

			Lines.Add(new Line(begin, MiddleDown, color));
			Lines.Add(new Line(MiddleDown, MiddleUp, color));
			Lines.Add(new Line(MiddleUp, end, color));
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			foreach (var line in Lines)
			{
				line.Draw(graphics, dashes);
			}
		}

		public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			throw new NotImplementedException();
		}
		public override void RotateTransform(Point origin, int angle)
		{
			throw new NotImplementedException();
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			throw new NotImplementedException();
		}
		public override void TranslatingTransform(int trX, int trY)
		{
			throw new NotImplementedException();
		}
	}
}
