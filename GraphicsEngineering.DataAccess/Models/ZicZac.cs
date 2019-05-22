using System;
using System.Collections.Generic;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public class ZicZac : Shape
	{
		public List<Point> Points { get; set; }
		public List<Line> Lines { get; set; }

		/// <summary>
		/// BeginPoint must on the right of EndPoint
		/// </summary>
		/// <param name="begin">On the Right</param>
		/// <param name="end">On the Left</param>
		public ZicZac(Point begin, Point end) : this(begin, end, Color.Black) { }
		public ZicZac(Point begin, Point end, Color color)
			: base(begin, end, color)
		{
			int distance = Math.Abs(begin.X - end.X);
			int distancePer10 = distance / 10;

			Points = new List<Point>();
			Lines = new List<Line>();

			int yDistance = 4;

			Points.Add(new Point(begin.X - distancePer10, begin.Y - yDistance / 2));
			Points.Add(new Point(Points[0].X - distancePer10, begin.Y + yDistance / 2));
			Points.Add(new Point(Points[1].X - distancePer10, begin.Y - yDistance / 2));
			Points.Add(new Point(Points[2].X - distancePer10, begin.Y + yDistance / 2));
			Points.Add(new Point(Points[3].X - distancePer10, begin.Y - yDistance / 2));
			Points.Add(new Point(Points[4].X - distancePer10, begin.Y + yDistance / 2));
			Points.Add(new Point(Points[5].X - distancePer10, begin.Y - yDistance / 2));
			Points.Add(new Point(Points[6].X - distancePer10, begin.Y + yDistance / 2));
			Points.Add(new Point(Points[7].X - distancePer10, begin.Y - yDistance / 2));

			for (int i = 0; i < 8; i++)
			{
				Lines.Add(new Line(Points[i], Points[i + 1], color));
			}
			Lines.Add(new Line(Points[0], begin, color));
			Lines.Add(new Line(Points[8], end, color));
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			foreach (var line in Lines)
			{
				line.Draw(graphics, dashes);
			}
		}

        public void ZicZacTransform()
        {
            Random rad = new Random();

            Point begin = Begin.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);
            Point end = End.ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT);

            int distance = Math.Abs(begin.X - end.X);
            int distancePer10 = distance / 10;

            Points.Clear();
            Lines.Clear();

            Points.Add(new Point(begin.X - distancePer10, begin.Y - rad.Next(1, 3)));
            Points.Add(new Point(Points[0].X - distancePer10, begin.Y + rad.Next(1, 3)));
            Points.Add(new Point(Points[1].X - distancePer10, begin.Y - rad.Next(1, 3)));
            Points.Add(new Point(Points[2].X - distancePer10, begin.Y + rad.Next(1, 3)));
            Points.Add(new Point(Points[3].X - distancePer10, begin.Y - rad.Next(1, 3)));
            Points.Add(new Point(Points[4].X - distancePer10, begin.Y + rad.Next(1, 3)));
            Points.Add(new Point(Points[5].X - distancePer10, begin.Y - rad.Next(1, 3)));
            Points.Add(new Point(Points[6].X - distancePer10, begin.Y + rad.Next(1, 3)));
            Points.Add(new Point(Points[7].X - distancePer10, begin.Y - rad.Next(1, 3)));

            for (int i = 0; i < 8; i++)
            {
                Lines.Add(new Line(Points[i], Points[i + 1], Color));
            }
            Lines.Add(new Line(Points[0], begin, Color));
            Lines.Add(new Line(Points[8], end, Color));
        }
        public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			throw new System.NotImplementedException();
		}
		public override void RotateTransform(Point origin, int angle)
		{
			throw new System.NotImplementedException();
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			throw new System.NotImplementedException();
		}
		public override void TranslatingTransform(int trX, int trY)
		{
			throw new System.NotImplementedException();
		}
	}
}
