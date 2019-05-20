using System.Drawing;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Models;

namespace GraphicsEngineering.DataAccess.ActionsHandler
{
	public class RectangleActionHandler : ActionsHandler
	{
		public RectangleActionHandler(PictureBox drawingArea, Rectangle rect)
			: base(drawingArea)
		{
			base.Shape = new MyRectangle(rect);
		}
	}
}
