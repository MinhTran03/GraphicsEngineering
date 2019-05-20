using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.ActionsHandler;
using GraphicsEngineering.DataAccess.Common;
using GraphicsEngineering.DataAccess.Models;

namespace GraphicsEngineering.GUI
{
	public partial class Form2D : Form
	{
		private List<Shape> shapes = new List<Shape>();
		private Grid grid;
		private Line line;
		private Line line2;
		private Mjolnir mjolnir;
		private int count = 0;
		private bool action1 = false;
		private bool action2 = false;
		private bool action3 = false;

		public Form2D()
		{
			InitializeComponent();
		}

		private void Form2D_Load(object sender, EventArgs e)
		{
			Constant.WIDTH_DRAWING_AREA = pbDrawingArea.Width;
			Constant.HEIGHT_DRAWING_AREA = pbDrawingArea.Height;
			grid = new Grid(pbDrawingArea);
			Rectangle rect = new Rectangle(-5, 15, 10, 15);

			line = new Line(new Point(0, 0), new Point(20, 20));
			line2 = new Line(new Point(0, 20), new Point(20, 20));
			mjolnir = new Mjolnir(rect);
		}

		private void lblMinimaze_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void lblClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			shapes.ForEach(shape => shape?.Dispose()); // Dispose if shape not null
		}
		private void ckbGridDraw_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbGridDraw.Checked)
			{
				grid.Draw();
			}
			else
			{
				grid.Clear();
			}
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			//shapes.ForEach(shape => shape?.Dispose());
			timer.Stop();
		}

		private void pbDrawingArea_MouseDown(object sender, MouseEventArgs e)
		{
			count = 0;
			timer.Start();
		}

		private void pbDrawingArea_Paint(object sender, PaintEventArgs e)
		{
			if (action1)
			{
				mjolnir.Draw(e.Graphics, Dashes.Solid);
				mjolnir.RotateTransform(new Point(0, 0), 45);
				count++;
			}
			else if(action2)
			{
				mjolnir.Draw(e.Graphics, Dashes.Solid);
				mjolnir.TranslatingTransform(1, 0);
				count++;
			}
			else if(action3)
			{
				mjolnir.Draw(e.Graphics, Dashes.Solid);
				mjolnir.RotateTransform(new Point(18, 0), -45);
				count++;
			}
			action1 = false;
			action2 = false;
			action3 = false;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if(count <= 1)
			{
				action1 = true;
				pbDrawingArea.Refresh();
			}
			else if(count <= 20)
			{
				timer.Interval = 200;
				action2 = true;
				pbDrawingArea.Refresh();
			}
			else if (count <= 23)
			{
				timer.Interval = 500;
				action3 = true;
				pbDrawingArea.Refresh();
			}
		}
	}
}