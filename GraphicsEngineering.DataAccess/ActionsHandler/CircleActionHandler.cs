using System.Drawing;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Models;

namespace GraphicsEngineering.DataAccess.ActionsHandler
{
	public class CircleActionHandler : ActionsHandler
	{
		public CircleActionHandler(PictureBox drawingArea, Rectangle rect)
			: base(drawingArea)
		{
			base.Shape = new Circle(rect);
		}
	}
}
