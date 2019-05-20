using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEngineering.GUI
{
	public class MyCheckBox : CheckBox
	{
		public MyCheckBox()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
			Padding = new Padding(3);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			this.OnPaintBackground(e);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (var path = new GraphicsPath())
			{
				int rCircle = Height - 2;
				int width = Width - 2;
				path.AddArc(width - rCircle - 1, 0, rCircle, rCircle, -90, 180);
				path.AddArc(0, 0, rCircle, rCircle, 90, 180);
				path.CloseFigure();
				e.Graphics.FillPath(Checked ? Brushes.LightGreen : Brushes.NavajoWhite, path);
				var rect = Checked ? new Rectangle(width - rCircle - 1, 0, rCircle, rCircle)
								   : new Rectangle(0, 0, rCircle, rCircle);
				e.Graphics.FillEllipse(Checked ? Brushes.WhiteSmoke : Brushes.WhiteSmoke, rect);
			}
		}
	}
}
