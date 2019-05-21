using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEngineering.Draw3D
{
	public class Grid3D
	{
		private PictureBox _area { get; set; }
		private Bitmap gridBackGround { get; set; }
		private Bitmap oldBackGround { get; set; }

		public Grid3D(PictureBox area)
		{
			_area = area;
			gridBackGround = new Bitmap(area.Width, area.Height);
			oldBackGround = (Bitmap)area.BackgroundImage;
		}

		public void Draw(Color color)
		{
			int width = _area.Width;
			int height = _area.Height;

			using (Graphics g = Graphics.FromImage(gridBackGround))
			{
				Pen pen = new Pen(color);

				var centerTop = new Point(width / 2, 0);
				var kernel = new Point(width / 2, height / 2);
				var centerRight = new Point(width, height / 2);
				var bottomLeft = new Point(0, height);

				g.DrawLine(pen, centerTop, kernel);
				g.DrawLine(pen, centerRight, kernel);
				g.DrawLine(pen, bottomLeft, kernel);

				_area.Image = gridBackGround;
			}
		}
		public void Clear()
		{
			_area.Image = oldBackGround;
		}
	}
}
