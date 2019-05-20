using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using GraphicsEngineering.GUI.Properties;

namespace GraphicsEngineering.GUI
{
	public partial class FormSelectMode : Form
	{
		Form2D form2D;
		Form3D form3D;

		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;

		//[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		//private static extern IntPtr CreateRoundRectRgn
		//(
		//	int nLeftRect,     // x-coordinate of upper-left corner
		//	int nTopRect,      // y-coordinate of upper-left corner
		//	int nRightRect,    // x-coordinate of lower-right corner
		//	int nBottomRect,   // y-coordinate of lower-right corner
		//	int nWidthEllipse, // height of ellipse
		//	int nHeightEllipse // width of ellipse
		//);

		public FormSelectMode()
		{
			InitializeComponent();

			using (DataSet dataSet = new DataSet())
			{
				//dataSet.ReadXml(@"F:\C# Advanced\GraphicsEngineering\TeamInfo.xml");
				dataSet.ReadXml(Application.StartupPath + @"\TeamInfo.xml");
				DataTable dataTable = new DataTable();
				dataTable = dataSet.Tables["students"];
				lblTeamName.Text = dataTable.Rows[0].ItemArray[1].ToString();
				dataTable = dataSet.Tables["student"];
				LoadName(dataTable);
				LoadIcon(dataTable);
			}
		}
		private void LoadName(DataTable dataTable)
		{
			int count = 0;
			using (ToolTip toolTip = new ToolTip())
			{
				foreach (Label lblMember in pnName.Controls)
				{
					DataRow row = dataTable.Rows[count++];
					lblMember.Text = row["name"].ToString();
					toolTip.SetToolTip(lblMember, row["id"].ToString());
				}
			}
		}
		private void LoadIcon(DataTable dataTable)
		{
			int count = 0;
			Bitmap iconMale = new Bitmap(Resources.male);
			Bitmap iconFemale = new Bitmap(Resources.female);
			foreach (PictureBox icon in fpnIcons.Controls)
			{
				DataRow row = dataTable.Rows[count++];
				if (string.Compare(row["gender"].ToString(), "male") == 0)
				{
					icon.Image = iconMale;
				}
				else
				{
					icon.Image = iconFemale;
				}
			}
		}

		private void ControlMouseDown()
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		private void ControlMouseUp()
		{
			dragging = false;
		}
		private void ControlMouseMove()
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void SelectModeForm_MouseDown(object sender, MouseEventArgs e)
		{
			ControlMouseDown();
		}
		private void SelectModeForm_MouseUp(object sender, MouseEventArgs e)
		{
			ControlMouseUp();
		}
		private void SelectModeForm_MouseMove(object sender, MouseEventArgs e)
		{
			ControlMouseMove();
		}
		private void pnMember_MouseDown(object sender, MouseEventArgs e)
		{
			ControlMouseDown();
		}
		private void pnMember_MouseUp(object sender, MouseEventArgs e)
		{
			ControlMouseUp();
		}
		private void pnMember_MouseMove(object sender, MouseEventArgs e)
		{
			ControlMouseMove();
		}

		private void lblClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void lblClose_MouseEnter(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.FromArgb(220,220,220);
		}
		private void lblClose_MouseLeave(object sender, EventArgs e)
		{
			lblClose.BackColor = this.BackColor;
		}
		private void lblMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void lblMinimize_MouseEnter(object sender, EventArgs e)
		{
			lblMinimize.BackColor = Color.FromArgb(220, 220, 220);
		}
		private void lblMinimize_MouseLeave(object sender, EventArgs e)
		{
			lblMinimize.BackColor = this.BackColor;
		}

		private void btn2DForm_Click(object sender, EventArgs e)
		{
			if (form2D == null)
			{
				form2D = new Form2D()
				{
					StartPosition = FormStartPosition.CenterScreen
				};
				form2D.Show();
				form2D.FormClosed += new FormClosedEventHandler((object o, FormClosedEventArgs args) =>
				{
					form2D.Dispose();
					form2D = null;
				});
			}
		}
		private void btn3DForm_Click(object sender, EventArgs e)
		{
			if (form3D == null)
			{
				form3D = new Form3D()
				{
					StartPosition = FormStartPosition.CenterScreen
				};
				form3D.Show();
				form3D.FormClosed += new FormClosedEventHandler((object o, FormClosedEventArgs args) =>
				{
					form3D.Dispose();
					form3D = null;
				});
			}
		}
	}
}
