using System;
using System.Drawing;
using System.Windows.Forms;
using GraphicsEngineering.Draw3D;
using GraphicsEngineering.DataAccess.Common;
using GraphicsEngineering.GUI.Properties;

namespace GraphicsEngineering.GUI
{
	public partial class Form3D : Form
	{
		private Grid3D grid3D;
		private Cube cube;
		private SquarePyramid squarePyramid;
		private Shape3DType selectionShape = Shape3DType.None;
		private Color color;

		public Form3D()
		{
			InitializeComponent();
			color = btnReviewColor.BackColor;
		}
		private void Form3D_Load(object sender, EventArgs e)
		{
			btnWhite.Focus();
			Constant.WIDTH_DRAWING_AREA = pbDrawingArea.Width;
			Constant.HEIGHT_DRAWING_AREA = pbDrawingArea.Height;

			grid3D = new Grid3D(pbDrawingArea);
			grid3D.Draw(Color.Black);

			MessageBox.Show(pbDrawingArea.Size.ToString() + "Check tỷ lệ màn hình xem vuông chưa");
			inputCube.Location = new Point(btnCube.Location.X, btnCube.Location.Y + btnCube.Height - 1);
		}

		private void lblClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void lblClose_MouseEnter(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.FromArgb(200, 28, 36);
		}
		private void lblClose_MouseLeave(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.FromArgb(54, 57, 65);
		}
		private void lblMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void lblMinimize_MouseEnter(object sender, EventArgs e)
		{
			lblMinimize.BackColor = Color.FromArgb(0, 100, 182);
		}
		private void lblMinimize_MouseLeave(object sender, EventArgs e)
		{
			lblMinimize.BackColor = Color.FromArgb(54, 57, 65);
		}

		private void ResetCube()
		{
			btnCube.BackColor = Color.FromArgb(240, 242, 243);
			btnCube.BackgroundImage = Resources.cubeGray;
			inputCube.Clear();
			inputCube.Visible = false;
		}
		private void ResetPyramid()
		{
			btnSquarePyramid.BackColor = Color.FromArgb(240, 242, 243);
			btnSquarePyramid.BackgroundImage = Resources.squarePyramidGray;
			inputPyramid.Clear();
			inputPyramid.Visible = false;
		}
		private void SelectCube()
		{
			selectionShape = Shape3DType.Cube;
			btnCube.BackColor = Color.FromArgb(54, 57, 65);
			btnCube.BackgroundImage = Resources.cubeWhite;
			ResetPyramid();
			inputCube.Visible = true;
		}
		private void SelectPyramid()
		{
			selectionShape = Shape3DType.SquarePyramid;
			btnSquarePyramid.BackColor = Color.FromArgb(54, 57, 65);
			btnSquarePyramid.BackgroundImage = Resources.squarePyramidWhite;
			ResetCube();
			inputPyramid.Visible = true;
		}
		private void OnChangedSelectionShape()
		{
			grbControls.Text = selectionShape.ToString();
		}
		private void OnChangedColor(object sender)
		{
			Button buttonColor = sender as Button;
			btnReviewColor.BackColor = buttonColor.BackColor;
			color = btnReviewColor.BackColor;
			grbColor.Text = buttonColor.Name.Remove(0, 3);
		}

		private void btnCube_Click(object sender, EventArgs e)
		{
			SelectCube();
		}
		private void btnSquarePyramid_Click(object sender, EventArgs e)
		{
			SelectPyramid();
		}

		private void btnWhite_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnLightGray_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnDarkGray_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnBlack_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnDarkRed_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnRed_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnOrange_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnGold_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnLightYellow_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnYellow_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnLime_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnGreen_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnAqua_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}
		private void btnTurquoise_Click(object sender, EventArgs e)
		{
			OnChangedColor(sender);
		}

		private void btnDraw_Click(object sender, EventArgs e)
		{
			using (Graphics g = pbDrawingArea.CreateGraphics())
			{
				switch (selectionShape)
				{
					case Shape3DType.Cube:
						int x = int.Parse(inputCube.txtCubeKernelX.Text);
						int y = int.Parse(inputCube.txtCubeKernelY.Text);
						int z = int.Parse(inputCube.txtCubeKernelZ.Text);
						int length = int.Parse(inputCube.txtCubeLength.Text);
						cube = new Cube(new Point3D(x, y, z), length);
						cube.Draw(g, color);
						lblInfo.Text += cube.ToString();
						break;
					case Shape3DType.SquarePyramid:
						x = int.Parse(inputPyramid.txtPyramidKernelX.Text);
						y = int.Parse(inputPyramid.txtPyramidKernelY.Text);
						z = int.Parse(inputPyramid.txtPyramidKernelZ.Text);
						int height = int.Parse(inputPyramid.txtPyramidHeight.Text);
						int baseEdge = int.Parse(inputPyramid.txtPyramidEdge.Text);
						squarePyramid = new SquarePyramid(new Point3D(x, y, z), height, baseEdge);
						squarePyramid.Draw(g, color);
						lblInfo.Text += squarePyramid.ToString();
						break;
					default:
						MessageBox.Show("Select a shape to draw", "Shape not found!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
				}
			}
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			using (Graphics g = pbDrawingArea.CreateGraphics())
			{
				g.Clear(pbDrawingArea.BackColor);
				grid3D.Draw(Color.Black);
				lblInfo.Text = "";
				ResetCube();
				ResetPyramid();
			}
		}
	}
}
