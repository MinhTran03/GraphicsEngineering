using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
    public class IronMan : Shape
    {
        public MyRectangle Head { get; set; }
        public MyRectangle LeftEye { get; set; }
        public MyRectangle RightEye { get; set; }
        public Line Mouth { get; set; }
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
        /// Only work on 3x4 screen
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
            Rectangle rectHead = new Rectangle(x + 5, y, width / 3 * 2, height / 3 - 2);
            Head = new MyRectangle(rectHead, color);

            //left eye
            Rectangle rectLeftEye = new Rectangle(x + 7, y - 5, 5, 2);
            LeftEye = new MyRectangle(rectLeftEye, color);
            
            //right eye
            Rectangle rectRightEye = new Rectangle(x + 18, y - 5, 5, 2);
            RightEye = new MyRectangle(rectRightEye, color);

            //mouth
            Mouth = new Line(new Point(x + 13, y - 13),new Point(x + 17,y - 13));

            //neck
            Neck = new Line(new Point(x + width / 3, y - (height / 3 - 1)), new Point(x + width * 2 / 3, y - (height / 3 - 1)), color);

            //body
            Rectangle rectBody = new Rectangle(x + 5, y - height / 3, width * 2 / 3, height / 3);
            Body = new MyRectangle(rectBody, color);

            //heart
            Rectangle rectHeart = new Rectangle(x + 8, y - height / 3 - 3, width * 2 / 4 - 1, height / 8);
            Heart = new MyTriangle(rectHeart, Color.DeepSkyBlue);

            //right arm
            Rectangle rectRightArm = new Rectangle(x, y - height / 3, width / 6, height *2 /9);
            RightArm = new MyRectangle(rectRightArm, color);

            //left arm
            Rectangle rectLeftArm = new Rectangle(x + width * 5 / 6, y - height / 3, width / 6, height * 2 / 9);
            LeftArm = new MyRectangle(rectLeftArm, color);

            //middle 2 leg
            Rectangle rectMiddle2Leg = new Rectangle(x + 13, y - height * 2 / 3, 4, height / 10);
            Middle2Leg = new MyRectangle(rectMiddle2Leg, color);

            //right leg
            Rectangle rectRightLeg = new Rectangle(x + 5, y - height * 2 / 3, 8, height / 4);
            RightLeg = new MyRectangle(rectRightLeg, color);

            //rocket right
            Rectangle rectRocketRight = new Rectangle(x + 6, y - 1 - height * 2 / 3 - height / 4, 6, height / 12 + 2);
            RocketRight = new MyTriangle(rectRocketRight,Color.OrangeRed);

            //left leg
            Rectangle rectLeftLeg = new Rectangle(x + 2 + width/2, y - height * 2 / 3, 8, height / 4 - 5);
            LeftLeg = new MyRectangle(rectLeftLeg, color);

            //rocket left
            Rectangle rectRocketLeft = new Rectangle(x + 18, y + 4 - height * 2 / 3 - height / 4, 6, height / 12 + 2);
            RocketLeft = new MyTriangle(rectRocketLeft, Color.OrangeRed);


        }

        public override void Draw(Graphics graphics, Dashes dashes)
        {
            Head.Draw(graphics, dashes);
            LeftEye.Draw(graphics, dashes);
            RightEye.Draw(graphics, dashes);
            Mouth.Draw(graphics, dashes);
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
            //Heart.Draw(graphics, dashes);
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
        }


        public void RotateLeftArm(int angle)
        {
            Point origin = LeftArm.Begin;
            LeftArm.End = LeftArm.End.Rotate(origin, angle);
        }
    }
}
