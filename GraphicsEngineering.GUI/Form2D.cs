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
		private ZicZac zicZac;
		private ZicZac zicZac1;
		private int count = 0;
		private bool isDraw = false;
		private bool actionHand90 = false;
		private bool actionMjolnirUp = false;
		private bool actionMjolnirRotate = false;
		private bool actionMjolnir2Cap = false;
		private bool actionHandUp = false;
		private bool actionMjolnirStraight = false;
		private List<bool> actionLightnings;
		private bool actionMjolnirRotate2 = false;
		private bool actionShootIronMan = false;

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

			var humanRect = new Rectangle(Cons.HUMAN_LOCATION, Cons.HUMAN_SIZE);
			human = new Human(humanRect, Color.White);

			var mjolnirRect = new Rectangle(Cons.MJOLNIR_LOCATION, Cons.MJOLNIR_SIZE);
			mjolnir = new Mjolnir(mjolnirRect, Color.White);
			mjolnir.RotateTransform(mjolnir.Kernel, 180);

			var beginZiczac = new Point(68, 22);
			var endZiczac = new Point(-80, 22);
			zicZac = new ZicZac(beginZiczac, endZiczac, Color.White);
			zicZac1 = new ZicZac(zicZac.Begin.Translating(0, -1).ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT), 
								zicZac.End.Translating(0, -1).ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT), Color.White);

			lightnings.Add(new Lightning(new Point(Cons.HUMAN_LOCATION.X + 5, 72), 
										new Point(Cons.HUMAN_LOCATION.X + 5, 44), Color.White));
			actionLightnings.Add(false);
			lightnings.Add(new Lightning(lightnings[0].Begin.Translating(-1,0).ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT), 
										lightnings[0].End.Translating(-1,0).ToWorldCoordinates(Cons.WIDTH, Cons.HEIGHT), Color.White));
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
		private void SetFalseAllActions()
		{
			actionHand90 = false;
			actionMjolnirUp = false;
			actionMjolnirRotate = false;
			actionMjolnir2Cap = false;
			actionHandUp = false;
			actionMjolnirStraight = false;
			for (int i = 0; i < actionLightnings.Count; i++) actionLightnings[i] = false;
			actionMjolnirRotate2 = false;
			actionShootIronMan = false;
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
				lightnings[1].Draw(e.Graphics, Dashes.Solid);
			}
			else if(actionMjolnirRotate2)
			{
				mjolnir.RotateTransform(human.RightArm.End, -90);
				mjolnir.TranslatingTransform(0, -5);
				human.RotateRightArm(-25);
			}
			else if(actionShootIronMan)
			{
				zicZac.Draw(e.Graphics, Dashes.Solid);
				zicZac1.Draw(e.Graphics, Dashes.Solid);
			}

			if (isDraw)
			{
				lblInfo.Text = human.ToString();
				lblInfo.Text += mjolnir.ToString();
				mjolnir.Draw(e.Graphics, Dashes.Solid);
				human.Draw(e.Graphics, Dashes.Solid);
				count++;
			}
			SetFalseAllActions();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			if(count < 10)
			{
				actionHand90 = true;
			}
			else if(count < 10 + 19)
			{
				actionMjolnirUp = true;
			}
			else if(count < 29 + 3)
			{
				actionMjolnirRotate = true;
			}
			else if(count < 32 + Cons.DISTANCE_THOR_MJOLNIR - Cons.MJOLNIR_SIZE.Width / 2)
			{
				timer.Interval = 1;
				actionMjolnir2Cap = true;
			}
			else if(count < 128 + 3)
			{
				timer.Interval = 50;
				actionHandUp = true;
			}
			else if(count < 131 + 1)
			{
				timer.Interval = 1;
				actionMjolnirStraight = true;
			}
			else if(count < 133 + 5)
			{
				timer.Interval = 200;
				actionLightnings[0] = true;
			}
			else if(count < 138 + 1)
			{
				actionMjolnirRotate2 = true;
			}
			else if(count < 139 +5)
			{
				timer.Interval = 200;
				actionShootIronMan = true;
			}

			if (isDraw)
			{
				pbDrawingArea.Refresh();
			}
		}
	}
}