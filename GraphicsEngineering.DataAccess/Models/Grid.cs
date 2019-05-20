using GraphicsEngineering.DataAccess.Common;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEngineering.DataAccess.Models
{
	public class Grid
	{
		private PictureBox _area { get; set; }
		private Bitmap gridBackGround { get; set; }
		private Bitmap oldBackGround { get; set; }

		public Grid(PictureBox area)
		{
			_area = area;
			gridBackGround = new Bitmap(area.Width, area.Height);
			oldBackGround = new Bitmap(area.Width, area.Height);

			using (Graphics g = Graphics.FromImage(oldBackGround))
			{
				var blackPen = new Pen(Color.Black);
				
				var redPen = new Pen(Color.Red);
				int temp = area.Width / 2;
				temp = temp.Round5();
				g.DrawLine(redPen, new Point(temp, 0), new Point(temp, area.Height));
				temp = area.Height / 2;
				temp = temp.Round5();
				g.DrawLine(redPen, new Point(0, temp), new Point(area.Width, temp));

				_area.BackgroundImage = oldBackGround;
			}
		}

		public void Draw()
		{
			int width = _area.Width;
			int height = _area.Height;

			using (Graphics g = Graphics.FromImage(gridBackGround))
			{
				var blackPen = new Pen(Color.Black);
				for (int col = 0; col < width; col += 5)
				{
					var start = new Point(col, 0);
					var end = new Point(col, height);
					g.DrawLine(blackPen, start, end);
				}
				for (int row = 0; row <= height; row += 5)
				{
					var start = new Point(0, row);
					var end = new Point(width, row);
					g.DrawLine(blackPen, start, end);
				}

				var redPen = new Pen(Color.Red);
				int temp = width / 2;
				temp = temp.Round5();
				g.DrawLine(redPen, new Point(temp, 0), new Point(temp, height));
				temp = height / 2;
				temp = temp.Round5();
				g.DrawLine(redPen, new Point(0, temp), new Point(width, temp));

				_area.BackgroundImage = gridBackGround;
			}
		}
		public void Clear()
		{
			_area.BackgroundImage = oldBackGround;
		}
	}
}
