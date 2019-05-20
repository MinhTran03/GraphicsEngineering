using System.Windows.Forms;

namespace GraphicsEngineering.GUI
{
	public partial class InputCube : UserControl
	{
		public InputCube()
		{
			InitializeComponent();
		}

		public void Clear()
		{
			txtCubeKernelX.Text = "";
			txtCubeKernelY.Text = "";
			txtCubeKernelZ.Text = "";
			txtCubeLength.Text = "";
		}
	}
}
