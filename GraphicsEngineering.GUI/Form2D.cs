using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Common;
using GraphicsEngineering.DataAccess.Models;

namespace GraphicsEngineering.GUI
{
	public partial class Form2D : Form
	{
		private Grid grid;
		private Mjolnir mjolnir;
		private Human human;
		private List<Lightning> lightnings;
		private int count = 0;
		private bool isDraw = false;
		private bool actionHand90 = false;
		private bool actionMjolnirUp = false;
		private bool actionMjolnirRotate = false;
		private bool actionMjolnir2Cap = false;
		private bool actionHandUp = false;
		private bool actionMjolnirStraight = false;
		private List<bool> actionLightnings;
		private bool actionSpinMjolnir = false;

		public Form2D()
		{
			InitializeComponent();
		}

		private void Form2D_Load(object sender, EventArgs e)
		{
			SetUpBasic();
			SetUpObjects();

			isDraw = true;
			//MessageBox.Show(pbDrawingArea.Size.ToString());
		}
		private void SetUpBasic()
		{
			Cons.WIDTH = pbDrawingArea.Width;
			Cons.HEIGHT = pbDrawingArea.Height;
			grid = new Grid(pbDrawingArea);
			Size screenResolution = new Size(pbDrawingArea.Width / 5, pbDrawingArea.Height / 5);
			lblScreenResolution.Text += screenResolution.ToString();
		}
		private void SetUpObjects()
		{
			lightnings = new List<Lightning>();
			actionLightnings = new List<bool>();

			var mjolnirRect = new Rectangle(-100, 18, 10, 18);
			mjolnir = new Mjolnir(mjolnirRect, Color.White);
			mjolnir.RotateTransform(mjolnir.Kernel, 180);

			var humanRect = new Rectangle(60, 40, 30, 40);
			human = new Human(humanRect, Color.Red);

			lightnings.Add(new Lightning(new Point(70, 72), new Point(65, 44), Color.FromArgb(169, 41, 238)));
			actionLightnings.Add(false);
			lightnings.Add(new Lightning(new Point(65, 72), new Point(65, 44), Color.FromArgb(169, 41, 238)));
			actionLightnings.Add(false);
			lightnings.Add(new Lightning(new Point(60, 72), new Point(60, 44), Color.FromArgb(169, 41, 238)));
			actionLightnings.Add(false);
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

		private void btnPlay_Click(object sender, EventArgs e)
		{
			count = 0;
			timer.Start();
		}
		private void btnPause_Click(object sender, EventArgs e)
		{
			timer.Stop();
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			timer.Stop();
			//MessageBox.Show(count.ToString());
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
			else if(actionLightnings[0])
			{
				lightnings[0].Draw(e.Graphics, Dashes.Solid);
			}
			else if (actionLightnings[1])
			{
				lightnings[1].Draw(e.Graphics, Dashes.Solid);
			}
			else if (actionLightnings[2])
			{
				lightnings[2].Draw(e.Graphics, Dashes.Solid);
			}
			else if(actionSpinMjolnir)
			{
				//mjolnir.RotateTransform(human.RightArm.End, 45);
			}

			if (isDraw)
			{
				lblInfo.Text = human.ToString();
				lblInfo.Text += mjolnir.ToString();
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
			for (int i = 0; i < actionLightnings.Count; i++) actionLightnings[i] = false;
			actionSpinMjolnir = false;
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
			else if(count < 187)
			{
				timer.Interval = 5;
				actionMjolnir2Cap = true;
			}
			else if(count < 191)
			{
				timer.Interval = 200;
				actionHandUp = true;
			}
			else if(count < 192)
			{
				timer.Interval = 1;
				actionMjolnirStraight = true;
			}
			else if(count < 193)
			{
				timer.Interval = 200;
				actionLightnings[0] = true;
			}
			else if(count < 194)
			{
				actionLightnings[1] = true;
			}
			else if(count < 195)
			{
				actionLightnings[2] = true;
			}
			else if(count < 250)
			{
				timer.Interval = 2000;
				actionSpinMjolnir = true;
			}

			if (isDraw)
			{
				pbDrawingArea.Refresh();
			}
		}
	}
}