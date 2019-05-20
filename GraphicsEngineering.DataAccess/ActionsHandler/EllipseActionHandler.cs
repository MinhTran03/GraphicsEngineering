using System.Drawing;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Models;

namespace GraphicsEngineering.DataAccess.ActionsHandler
{
	public class EllipseActionHandler : ActionsHandler
	{
		public EllipseActionHandler(PictureBox drawingArea, Rectangle rect)
			: base(drawingArea)
		{
			base.Shape = new Ellipse(rect);
		}
	}
}
