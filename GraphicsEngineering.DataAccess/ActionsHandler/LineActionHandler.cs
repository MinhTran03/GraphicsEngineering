using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Models;
using System.Drawing;

namespace GraphicsEngineering.DataAccess.ActionsHandler
{
	public class LineActionHandler : ActionsHandler
	{
		public LineActionHandler(PictureBox drawingArea, Point begin, Point end)
			: base(drawingArea)
		{
			base.Shape = new Line(begin, end);
		}
	}
}
