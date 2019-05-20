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
		private Grid grid;
		private Mjolnir mjolnir;
		private Human human;
		private int count = 0;
		private bool isDraw = false;
		private bool actionHand90 = false;
		private bool actionMjolnirUp = false;
		private bool actionMjolnirRotate = false;
		private bool actionMjolnir2Cap = false;
		private bool actionHandUp = false;
		private bool actionMjolnirStraight = false;

		public Form2D()
		{
			InitializeComponent();
		}

		private void Form2D_Load(object sender, EventArgs e)
		{
			Cons.WIDTH = pbDrawingArea.Width;
			Cons.HEIGHT = pbDrawingArea.Height;
			grid = new Grid(pbDrawingArea);

			//MessageBox.Show(pbDrawingArea.Size.ToString());
			var mjolnirRect = new Rectangle(-100, 18, 10, 18);
			mjolnir = new Mjolnir(mjolnirRect);
			mjolnir.RotateTransform(mjolnir.Kernel, 180);

			var humanRect = new Rectangle(60, 40, 30, 40);
			human = new Human(humanRect);

			isDraw = true;
			pbDrawingArea.Refresh();
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
			//shapes.ForEach(shape => shape?.Dispose()); // Dispose if shape not null
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
			timer.Stop();
			//MessageBox.Show(count.ToString());
		}

		private void pbDrawingArea_MouseDown(object sender, MouseEventArgs e)
		{
			count = 0;
			timer.Start();
		}

		private void pbDrawingArea_Paint(object sender, PaintEventArgs e)
		{
			if (actionHand90)
			{
				human.RotateRightArm(5);
			}
			else if(actionMjolnirUp)
			{
				mjolnir.TranslatingTransform(0, 1);
			}
			else if(actionMjolnirRotate)
			{
				mjolnir.RotateTransform(mjolnir.Kernel, 45);
			}
			else if(actionMjolnir2Cap)
			{
				mjolnir.TranslatingTransform(1, 0);
			}
			else if(actionHandUp)
			{
				human.RotateRightArm(5);
				mjolnir.TranslatingTransform(0, 1);
			}
			else if(actionMjolnirStraight)
			{
				human.RotateRightArm(5);
				mjolnir.RotateTransform(human.RightArm.End, 45);
			}

			if(isDraw)
			{
				mjolnir.Draw(e.Graphics, Dashes.Solid);
				human.Draw(e.Graphics, Dashes.Solid);
				count++;
			}
			actionHand90 = false;
			actionMjolnirUp = false;
			actionMjolnirRotate = false;
			actionMjolnir2Cap = false;
			actionHandUp = false;
			actionMjolnirStraight = false;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if(count < 10)
			{
				actionHand90 = true;
			}
			else if(count < 29)
			{
				actionMjolnirUp = true;
			}
			else if(count < 32)
			{
				actionMjolnirRotate = true;
			}
			else if(count < 186)
			{
				timer.Interval = 10;
				actionMjolnir2Cap = true;
			}
			else if(count < 190)
			{
				timer.Interval = 200;
				actionHandUp = true;
			}
			else if(count < 191)
			{
				timer.Interval = 1;
				actionMjolnirStraight = true;
			}

			if(isDraw)
			{
				pbDrawingArea.Refresh();
			}
		}
	}
}