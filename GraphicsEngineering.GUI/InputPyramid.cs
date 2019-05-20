using System.Windows.Forms;

namespace GraphicsEngineering.GUI
{
	public partial class InputPyramid : UserControl
	{
		public InputPyramid()
		{
			InitializeComponent();
		}

		public void Clear()
		{
			txtPyramidEdge.Text = "";
			txtPyramidHeight.Text = "";
			txtPyramidKernelX.Text = "";
			txtPyramidKernelY.Text = "";
			txtPyramidKernelZ.Text = "";
		}
	}
}
