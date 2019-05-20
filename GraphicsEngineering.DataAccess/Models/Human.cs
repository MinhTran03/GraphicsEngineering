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

        public Human(Rectangle rect) : this(rect, Color.Black) { }
        public Human(Rectangle rect, Color color)
            : base(rect, color)
        {
            Rectangle rectangle = Region.ToWorldRectangle(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
            Rectangle head = new Rectangle(rectangle.Location.X + rectangle.Width / 3, rectangle.Location.Y,
                rectangle.Width / 3, rectangle.Height / 4);
            Head = new Circle(head);
            Body = new Line(new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y - head.Height),
                new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y - (int)(head.Height * 2.5f)));

            RightArm = new Line(new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y - (int)(head.Height * 1.5f)),
                new Point(rectangle.Location.X + rectangle.Width / 4, rectangle.Location.Y - (int)(head.Height * 1.9f)));

            LeftArm = new Line(new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y - (int)(head.Height * 1.5f)),
                new Point(rectangle.Location.X + rectangle.Width * 3 / 4, rectangle.Location.Y - (int)(head.Height * 1.9f)));

            RightLeg = new Line(new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y - (int)(head.Height * 2.5f)),
                new Point(rectangle.Location.X + rectangle.Width / 3, rectangle.Location.Y - (int)(head.Height * 3)));

            LeftLeg = new Line(new Point(rectangle.Location.X + rectangle.Width / 2, rectangle.Location.Y - (int)(head.Height * 2.5f)),
                new Point(rectangle.Location.X + rectangle.Width * 2 / 3, rectangle.Location.Y - (int)(head.Height * 3)));
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
            throw new NotImplementedException();
        }
    }
}
