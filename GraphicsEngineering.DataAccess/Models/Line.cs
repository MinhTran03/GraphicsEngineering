using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public class Line : Shape
	{
		public int Length { get; set; }

		public Line(Point begin, Point end)
			: this(begin, end, Color.Black) { }
		public Line(Point begin, Point end, Color color)
			: base(begin, end, color)
		{
			OnChangedLength();
		}

		private void Put8PixelsLine(Color color, Point start, int run, int follow, int dx, int dy)
		{
			if (dx >= dy && dx > 0 && dy >= 0) PutPixel(color, start.X + run, start.Y + follow);
			else if (dx < dy && dx >= 0 && dy > 0) PutPixel(color, start.X + follow, start.Y + run);
			else if (Math.Abs(dx) < dy && dx <= 0 && dy > 0) PutPixel(color, start.X - follow, start.Y + run);
			else if (Math.Abs(dx) >= dy && dx < 0 && dy >= 0) PutPixel(color, start.X - run, start.Y + follow);
			else if (Math.Abs(dx) >= Math.Abs(dy) && dx < 0 && dy <= 0) PutPixel(color, start.X - run, start.Y - follow);
			else if (Math.Abs(dx) < Math.Abs(dy) && dx <= 0 && dy < 0) PutPixel(color, start.X - follow, start.Y - run);
			else if (dx < Math.Abs(dy) && dx >= 0 && dy < 0) PutPixel(color, start.X + follow, start.Y - run);
			else if (dx >= Math.Abs(dy) && dx > 0 && dy <= 0) PutPixel(color, start.X + run, start.Y - follow);
		}
		private void OnChangedLength()
		{
			int x = Math.Abs(Begin.X - End.X);
			int y = Math.Abs(Begin.Y - End.Y);
			Length = (int)Math.Sqrt(x * x + y * y);
		}

		public override void Draw(Graphics graphics, Dashes dashes)
		{
			//base.Graphics?.Dispose();
			base.Graphics = graphics;

			int dashLength = 2;
			int count = 0;

			int dx = End.X - Begin.X;
			int dy = End.Y - Begin.Y;
			int dRun = Math.Abs(dx) >= Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
			int dFollow = Math.Abs(dx) < Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
			int follow = 0;
			int p = 2 * dFollow - dRun;
			for (int run = 0; run <= dRun; run += 5)
			{
				if (dashes == Dashes.Dash)
				{
					if (count % (2 * dashLength) == 0) count = 0;
					if (count == 0 || count == 1)
					{
						Put8PixelsLine(Color, Begin, run, follow, dx, dy);
					}
					count++;
				}
				else
				{
					Put8PixelsLine(Color, Begin, run, follow, dx, dy);
				}

				if (p < 0)
					p += 2 * dFollow;
				else
				{
					follow += 5;
					p += 2 * (dFollow - dRun);
				}
			}
		}
		public override string ToString()
		{
			Point worldBegin = Begin.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Point worldEnd= End.ToWorldCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			return $"Line: \n" +
				$"\t + Begin: {worldBegin.ToString()} \n" +
				$"\t + End: {worldEnd.ToString()} \n" +
				$"\t + Length: {(Length / 5).ToString()} \n";
		}

		// Khi chạy hiệu ứng cần update lại Begin, End, [Length]
		public override void TranslatingTransform(int trX, int trY)
		{
			Begin = Begin.Translating(trX, trY);
			End = End.Translating(trX, trY);
		}
		public override void ScaleTransform(Point origin, double scaleX, double scaleY)
		{
			Begin = Begin.Scale(origin, scaleX, scaleY);
			End = End.Scale(origin, scaleX, scaleY);
			OnChangedLength();
		}
		public override void RotateTransform(Point origin, int angle)
		{
			Begin = Begin.Rotate(origin, angle);
			End = End.Rotate(origin, angle);
		}
		public override void OppositeTransform(Point origin, OppositeType oppositeType)
		{
			Begin = Begin.Opposite(origin, oppositeType);
			End = End.Opposite(origin, oppositeType);
		}
	}
}
