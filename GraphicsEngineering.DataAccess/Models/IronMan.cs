using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
    public class IronMan : Shape
    {
        public MyRectangle Head { get; set; }
        public MyRectangle LeftEye { get; set; }
        public MyRectangle RightEye { get; set; }
        public Trapezoid Mouth { get; set; }
        public Line Neck { get; set; }
        public MyRectangle Body { get; set; }
        public MyTriangle Heart { get; set; }
        public MyRectangle RightArm { get; set; }
        public MyRectangle LeftArm { get; set; }
        public MyRectangle Middle2Leg { get; set; }
        public MyRectangle RightLeg { get; set; }
        public MyTriangle RocketRight { get; set; }
        public MyRectangle LeftLeg { get; set; }
        public MyTriangle RocketLeft { get; set; }

        /// <summary>
        /// Only work on 3x6 screen
        /// </summary>
        /// <param name="rect"></param>
        public IronMan(Rectangle rect) : this(rect, Color.Black) { }
        public IronMan(Rectangle rect, Color color)
            : base(rect, color)
        {
            int x = rect.X;
            int y = rect.Y;
            int width = rect.Width;
            int height = rect.Height;
            int headSize = (int)Math.Round((height / 4) * 1.25);
            int centerWidth = width / 2;

            //head
            Rectangle rectHead = new Rectangle(x + 5, y - 2, width / 3 * 2 - 2, height / 3 - 4);
            Head = new MyRectangle(rectHead, color);

            //left eye
            Rectangle rectLeftEye = new Rectangle(x + 9, y - 7, 4, 1);
            LeftEye = new MyRectangle(rectLeftEye, Color.FromArgb(67, 222, 248));
            
            //right eye
            Rectangle rectRightEye = new Rectangle(x + 17, y - 7, 4, 1);
            RightEye = new MyRectangle(rectRightEye, Color.FromArgb(67, 222, 248));

			//mouth
			Rectangle rectMouth = new Rectangle(rectHead.Location.X + 4, rectHead.Location.Y - rectHead.Height * 4 / 5 - 2,
												rectHead.Width / 2 + 3, rectHead.Height / 5 - 1);
			Mouth = new Trapezoid(rectMouth, color);

            //neck
            Neck = new Line(new Point(x + width / 3 - 1, y - (height / 3 - 1)), new Point(x + width * 2 / 3, y - (height / 3 - 1)), color);

            //body
            Rectangle rectBody = new Rectangle(x + 5, y - height / 3, width * 2 / 3 - 2, height / 3 - 1);
            Body = new MyRectangle(rectBody, color);

			//heart
			Rectangle rectHeart = new Rectangle(x + 10, y - height / 3 - 3, width * 2 / 4 - 5, height / 8 - 2);
            Heart = new MyTriangle(rectHeart, Color.DeepSkyBlue);

            //right arm
            Rectangle rectRightArm = new Rectangle(x, y - height / 3, width / 6, height *2 /9);
            RightArm = new MyRectangle(rectRightArm, color);

			//left arm
			//Rectangle rectLeftArm = new Rectangle(x + width * 5 / 6 - 2, y - height / 3, width / 6, height * 2 / 9);
			Point origin = new Point(rectHead.Width / 2 + rectHead.X, 0);
			Point location = rectRightArm.Location.Translating(rectRightArm.Width / 5, 0)
								.Opposite(origin, OppositeType.VerticalAxis);
									//.ToComputerCoordinates(Cons.WIDTH, Cons.HEIGHT);
			Rectangle rectLeftArm = new Rectangle(location,
													new Size(RightArm.Region.Size.Width / 5, RightArm.Region.Height / 5));
            LeftArm = new MyRectangle(rectLeftArm, color);

            //middle 2 leg
            Rectangle rectMiddle2Leg = new Rectangle(x + 13, y - height * 2 / 3 + 1, 4, height / 10);
            Middle2Leg = new MyRectangle(rectMiddle2Leg, color);

            //right leg
            Rectangle rectRightLeg = new Rectangle(x + 5, y - height * 2 / 3 + 1, 8, height / 4);
            RightLeg = new MyRectangle(rectRightLeg, color);

            //rocket right
            Rectangle rectRocketRight = new Rectangle(x + 6, y - 1 - height * 2 / 3 - height / 4 + 1, 6, height / 12);
            RocketRight = new MyTriangle(rectRocketRight,Color.OrangeRed);

            //left leg
            Rectangle rectLeftLeg = new Rectangle(x + 3 + width/2 - 1, y - height * 2 / 3 + 1, 6, height / 4 - 5);
            LeftLeg = new MyRectangle(rectLeftLeg, color);

            //rocket left
            Rectangle rectRocketLeft = new Rectangle(x + 18, y + 4 - height * 2 / 3 - height / 4 + 1, 4, height / 12);
            RocketLeft = new MyTriangle(rectRocketLeft, Color.OrangeRed);
        }

        public override void Draw(Graphics graphics, Dashes dashes)
        {
            Mouth.Draw(graphics, dashes);
            Head.Draw(graphics, dashes);
            LeftEye.Draw(graphics, dashes);
            RightEye.Draw(graphics, dashes);
            Neck.Draw(graphics, dashes);
            Body.Draw(graphics, dashes);
            Heart.Draw(graphics, dashes);
            RightArm.Draw(graphics, dashes);
            LeftArm.Draw(graphics, dashes);
            RightLeg.Draw(graphics, dashes);
            RocketRight.Draw(graphics, dashes);
            LeftLeg.Draw(graphics, dashes);
            RocketLeft.Draw(graphics, dashes);
            Middle2Leg.Draw(graphics, dashes);

			// tô màu
			// mắt
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(67, 222, 248)), 
												RightEye.Region.X - 2, RightEye.Region.Y - 2,
												RightEye.Region.Width + 4, RightEye.Region.Height + 4);
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(67, 222, 248)),
												LeftEye.Region.X - 2, LeftEye.Region.Y - 2,
												LeftEye.Region.Width + 4, LeftEye.Region.Height + 4);
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)),
												RightEye.Region.X + 1, RightEye.Region.Y + 1,
												RightEye.Region.Width - 2, RightEye.Region.Height - 2);
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)),
												LeftEye.Region.X + 1, LeftEye.Region.Y + 1,
												LeftEye.Region.Width - 2, LeftEye.Region.Height - 2);
			// heart
			var A = new Point(Heart.A.X - 3, Heart.A.Y - 1);
			var B = new Point(Heart.B.X + 3, Heart.B.Y - 1);
			var C = new Point(Heart.G.X, Heart.G.Y + 4);
			graphics.FillPolygon(new SolidBrush(Color.DeepSkyBlue), new Point[] { A, B, C});
		}
        public override string ToString()
        {
            return
                $"> Human \n" +
                $"  - Head: {Head.ToString()}" +
                $"  - Body: {Body.ToString()}" +
                $"  - Right Arm: {RightArm.ToString()}" +
                $"  - Left Arm: {LeftArm.ToString()}" +
                $"  - Right Leg: {RightLeg.ToString()}" +
                $"  - Left Leg: {LeftLeg.ToString()}";
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
            Head.TranslatingTransform(trX, trY);
            LeftEye.TranslatingTransform(trX, trY);
            RightEye.TranslatingTransform(trX, trY);
            Mouth.TranslatingTransform(trX, trY);
            Body.TranslatingTransform(trX, trY);
            Heart.TranslatingTransform(trX, trY);
            LeftArm.TranslatingTransform(trX, trY);
            RightArm.TranslatingTransform(trX, trY);
            LeftLeg.TranslatingTransform(trX, trY);
            RightLeg.TranslatingTransform(trX, trY);
            Neck.TranslatingTransform(trX, trY);
            Middle2Leg.TranslatingTransform(trX, trY);
            RocketLeft.TranslatingTransform(trX, trY);
            RocketRight.TranslatingTransform(trX, trY);
			Region.Location = Region.Location.Translating(trX, trY);
        }

        public void RotateLeftArm(int angle)
        {
			Point origin = new Point(LeftArm.Region.X + (int)(LeftArm.Width / 2), LeftArm.Region.Y + (int)(LeftArm.Width / 2));
			LeftArm.RotateTransform(origin, angle);
        }
    }
}
