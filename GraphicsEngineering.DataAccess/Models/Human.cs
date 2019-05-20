using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
    public class Human : Shape
    {
        public Circle Head { get; set; }
        public Line Body { get; set; }
        public Line RightArm { get; set; }
        public Line LeftArm { get; set; }
        public Line RightLeg { get; set; }
        public Line LeftLeg { get; set; }

		/// <summary>
		/// Only work on 3x4 screen
		/// </summary>
		/// <param name="rect"></param>
        public Human(Rectangle rect) : this(rect, Color.Black) { }
        public Human(Rectangle rect, Color color)
            : base(rect, color)
        {
			int x = rect.X;
			int y = rect.Y;
			int width = rect.Width;
			int height = rect.Height;
			int headSize = (int)Math.Round((height / 4) * 1.25);
			int centerWidth = width / 2;

            Rectangle rectHead = new Rectangle(x + (width - headSize) / 2, y, headSize, headSize);
            Head = new Circle(rectHead);
            Body =		new Line(new Point(x + centerWidth, y - rectHead.Height),
									new Point(x + centerWidth, y - (int)(height * 0.7f)));
            RightArm =	new Line(new Point(x + centerWidth, y - (int)(height * 0.43f)),
									new Point(x + (width - headSize) / 2, y - (int)(height * 0.7f)));
            LeftArm =	new Line(new Point(x + centerWidth, y - (int)(height * 0.43f)),
									new Point(x + (width - headSize) / 2 + headSize, y - (int)(height * 0.7f)));
            RightLeg =	new Line(new Point(x + centerWidth, y - (int)(height * 0.7f)),
									new Point(x + (width - headSize) / 2, y - height));
            LeftLeg =	new Line(new Point(x + centerWidth, y - (int)(height * 0.7f)),
									new Point(x + (width - headSize) / 2 + headSize, y - height));
        }

        public override void Draw(Graphics graphics, Dashes dashes)
        {
            Head.Draw(graphics, dashes);
            Body.Draw(graphics, dashes);
            RightArm.Draw(graphics, dashes);
            LeftArm.Draw(graphics, dashes);
            RightLeg.Draw(graphics, dashes);
            LeftLeg.Draw(graphics, dashes);
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
            Head.TranslatingTransform(trX,trY);
            Body.TranslatingTransform(trX, trY);
            LeftArm.TranslatingTransform(trX, trY);
            RightArm.TranslatingTransform(trX, trY);
            LeftLeg.TranslatingTransform(trX, trY);
            RightLeg.TranslatingTransform(trX, trY);
        }

		public void RotateRightArm(int angle)
		{
			Point origin = RightArm.Begin;
			RightArm.End = RightArm.End.Rotate(origin, angle);
		}
    }
}
