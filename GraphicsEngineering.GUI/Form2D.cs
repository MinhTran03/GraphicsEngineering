using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Common;
using GraphicsEngineering.DataAccess.Models;

namespace GraphicsEngineering.GUI
{
	public partial class Form2D : Form
	{
		private Grid grid;
		private Mjolnir mjolnir;
		private Thor human;
		private List<Lightning> lightnings;
		private ZicZac zicZac;
		private ZicZac zicZac1;
		private IronMan ironMan;
		private Circle kamehamehaBig;
		private Circle kamehamehaSmall;
		private MyRectangle kamehamehaGo1;
		private MyRectangle kamehamehaGo2;
		private int count = -1;
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
		private bool actionShootIronMan2 = false;
		private bool ironManUp = false;
		private bool ironManDown = false;
		private bool actionIronGetHit = false;
		private bool actionHumanHandDown = false;
		private bool actionKamehamehaCharge = false;
		private bool actionKamehamehaGo1 = false;
		private bool actionKamehamehaGo2 = false;
        private SoundPlayer player = new SoundPlayer();

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
            player.SoundLocation = @"C:\Users\quylo\Downloads\Music\audio.wav";
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

			ironMan = new IronMan(new Rectangle(-70, 60, 30, 60), Color.DarkRed);

			var humanRect = new Rectangle(Cons.HUMAN_LOCATION, Cons.HUMAN_SIZE);
			human = new Thor(humanRect, Color.White);

			var mjolnirRect = new Rectangle(Cons.MJOLNIR_LOCATION, Cons.MJOLNIR_SIZE);
			mjolnir = new Mjolnir(mjolnirRect, Color.White);
			mjolnir.RotateTransform(mjolnir.Kernel, 180);

			var beginZiczac = new Point(65, 26);
			var endZiczac = new Point(-47, 26);
			zicZac = new ZicZac(beginZiczac, endZiczac, Color.White);
			zicZac1 = new ZicZac(zicZac.Begin.Translating(0, -1).ToWorldCoordinates(),
								zicZac.End.Translating(0, -1).ToWorldCoordinates(), Color.White);

			lightnings.Add(new Lightning(new Point(Cons.HUMAN_LOCATION.X + 2, 103),
										new Point(Cons.HUMAN_LOCATION.X + 2, 48), Color.White));
			actionLightnings.Add(false);
			lightnings.Add(new Lightning(lightnings[0].Begin.Translating(-1, 0).ToWorldCoordinates(),
										lightnings[0].End.Translating(-1, 0).ToWorldCoordinates(), Color.White));
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
			isDraw = true;
			//count = 0;
			timer.Start();
			timer1.Start();
            player.Play();

        }
		private void btnReset_Click(object sender, EventArgs e)
		{
			count = -1;
			SetUpObjects();
			pbDrawingArea.Refresh();
			timer.Stop();
		}
		private void btnPause_Click(object sender, EventArgs e)
		{
			timer.Stop();
			isDraw = false;
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
			ironManUp = false;
			ironManDown = false;
			actionIronGetHit = false;
			actionKamehamehaCharge = false;
			actionHumanHandDown = false;
			actionKamehamehaGo1 = false;
			actionKamehamehaGo2 = false;
			actionShootIronMan2 = false;
		}

		private void pbDrawingArea_Paint(object sender, PaintEventArgs e)
		{
			if (actionHand90)
			{
				human.RotateRightArm(5);
			}
			else if (actionMjolnirUp)
			{
				mjolnir.TranslatingTransform(0, 1);
			}
			else if (actionMjolnirRotate)
			{
				mjolnir.RotateTransform(mjolnir.Kernel, 45);
			}
			else if (actionMjolnir2Cap)
			{
				mjolnir.TranslatingTransform(1, 0);
			}
			else if (actionHandUp)
			{
				human.RotateRightArm(5);
				mjolnir.TranslatingTransform(0, 1);
			}
			else if (actionMjolnirStraight)
			{
				human.RotateRightArm(5);
				mjolnir.RotateTransform(human.RightArm.End, 45);
			}
			else if (actionLightnings[0])
			{
				lightnings[0].Draw(e.Graphics, Dashes.Solid);
				lightnings[1].Draw(e.Graphics, Dashes.Solid);
			}
			else if (actionMjolnirRotate2)
			{
				mjolnir.RotateTransform(human.RightArm.End, -90);
				mjolnir.TranslatingTransform(0, -5);
				human.RotateRightArm(-20);
			}
			else if (actionShootIronMan)
			{
				zicZac.ZicZacTransform();
				zicZac1.ZicZacTransform();
				zicZac.End = zicZac.End.Translating(-1, 0);
				zicZac1.End = zicZac1.End.Translating(-1, 0);
				zicZac.Draw(e.Graphics, Dashes.Solid);
				zicZac1.Draw(e.Graphics, Dashes.Solid);
				ironMan.TranslatingTransform(-1, 0);
			}
			else if(actionShootIronMan2)
			{
				zicZac.ZicZacTransform();
				zicZac1.ZicZacTransform();
				zicZac.Draw(e.Graphics, Dashes.Solid);
				zicZac1.Draw(e.Graphics, Dashes.Solid);
			}
			else if(actionIronGetHit)
			{
				ironMan.RotateLeftArm(-90);
				Point point = new Point(ironMan.LeftArm.Region.X + ironMan.LeftArm.Region.Height + 45,
										ironMan.LeftArm.Region.Y - ironMan.LeftArm.Region.Width + 10)
										.ToWorldCoordinates();
				var rectSmall = new Rectangle(point, new Size(3, 3));
				point = point.ToComputerCoordinates().Translating(-2, 2).ToWorldCoordinates();
				var rectBig = new Rectangle(point, new Size(7, 7));
				kamehamehaSmall = new Circle(rectSmall, Color.FromArgb(147, 209, 236));
				kamehamehaBig = new Circle(rectBig, Color.FromArgb(83, 133, 243));
			}
			else if(actionHumanHandDown)
			{
				mjolnir.RotateTransform(mjolnir.Kernel, 45);
				mjolnir.TranslatingTransform(9, -7);
				human.RotateRightArm(-60);
			}
			else if(actionKamehamehaCharge)
			{
				kamehamehaSmall.Draw(e.Graphics, Dashes.Solid);
				kamehamehaBig.Draw(e.Graphics, Dashes.Solid);
				//tô màu
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(83, 133, 243)), 
										kamehamehaBig.Region.X - 4, kamehamehaBig.Region.Y - 4, 
										kamehamehaBig.Region.Width + 8, kamehamehaBig.Region.Height + 8);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(147, 209, 236)),
										kamehamehaSmall.Region.X - 4, kamehamehaSmall.Region.Y - 4,
										kamehamehaSmall.Region.Width + 8, kamehamehaSmall.Region.Height + 8);
				kamehamehaSmall.ScaleTransform(kamehamehaSmall.Kernel, 5, 5);
				kamehamehaBig.ScaleTransform(kamehamehaBig.Kernel, 3, 3);
			}
			else if(actionKamehamehaGo1)
			{
				// scale lại để lấy tọa độ cho kamehamehaGo
				kamehamehaSmall.ScaleTransform(kamehamehaSmall.Kernel, 0.2, 0.2);
				kamehamehaBig.ScaleTransform(kamehamehaBig.Kernel, 0.3, 0.3);
				ironMan.TranslatingTransform(-kamehamehaBig.Region.Width / 5, 0);
				var location = new Point(kamehamehaBig.Region.X, kamehamehaBig.Kernel.Y - 10)
										.ToWorldCoordinates();
				var size = new Size(35, 2);
				var rect = new Rectangle(location, size);
				kamehamehaGo1 = new MyRectangle(rect, Color.DarkSlateBlue);
				kamehamehaGo1.Draw(e.Graphics, Dashes.Solid);
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(83, 133, 243)), 
									kamehamehaGo1.Region.X - 1, kamehamehaGo1.Region.Y - 1,
									kamehamehaGo1.Region.Width + 8, kamehamehaGo1.Region.Height + 3);

				// tính vị trí của kamehamehaGo2
				location = location.ToComputerCoordinates().Translating(45, 0);
				kamehamehaGo2 = new MyRectangle(new Rectangle(location.ToWorldCoordinates(), 
															new Size(75, 2)), Color.DarkSlateBlue);

				// di chuyển đến vị trí Thor
				kamehamehaSmall.TranslatingTransform(110, 0);
				kamehamehaBig.TranslatingTransform(110, 0);

				//thor đưa tay trái cầm búa
				mjolnir.TranslatingTransform(-1, 1);
				human.RotateRightArm(15);
				human.RotateLeftArm(55);
			}
			else if(actionKamehamehaGo2)
			{
				mjolnir.RotateTransform(mjolnir.Kernel, 45);
				mjolnir.TranslatingTransform(-2, 15);
				human.RotateRightArm(60);
				human.RotateLeftArm(60);

				kamehamehaGo2.Draw(e.Graphics, Dashes.Solid);
				kamehamehaSmall.Draw(e.Graphics, Dashes.Solid);
				kamehamehaBig.Draw(e.Graphics, Dashes.Solid);

				//tô màu
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(83, 133, 243)),
									kamehamehaGo2.Region.X - 1, kamehamehaGo2.Region.Y - 1,
									kamehamehaGo2.Region.Width + 3, kamehamehaGo2.Region.Height + 3);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(83, 133, 243)),
										kamehamehaBig.Region.X - 4, kamehamehaBig.Region.Y - 4,
										kamehamehaBig.Region.Width + 8, kamehamehaBig.Region.Height + 8);
				e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(147, 209, 236)),
										kamehamehaSmall.Region.X - 4, kamehamehaSmall.Region.Y - 4,
										kamehamehaSmall.Region.Width + 8, kamehamehaSmall.Region.Height + 8);
			}

			if (isDraw)
			{
				//if (ironManUp)
				//{
				//	ironMan.TranslatingTransform(0, 3);
				//}
				//else if (ironManDown)
				//{
				//	//if(ironMan.Region.Location.ToWorldCoordinates().Y > 60) 
				//	ironMan.TranslatingTransform(0, -3);
				//}

				txtInfo.Text = human.ToString();
				txtInfo.Text += mjolnir.ToString();
				txtInfo.Text += ironMan.ToString();
				mjolnir.Draw(e.Graphics, Dashes.Solid);
				human.Draw(e.Graphics, Dashes.Solid);
				ironMan.Draw(e.Graphics, Dashes.Solid);
				count++;
			}
			SetFalseAllActions();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			if (count < 12)
			{
				timer.Interval = 1;
				actionHand90 = true;
			}
			else if (count < 12 + 23)
			{
				actionMjolnirUp = true;
			}
			else if (count < 35 + 3)
			{
				actionMjolnirRotate = true;
			}
			else if (count < 38 + Cons.DISTANCE_THOR_MJOLNIR - Cons.MJOLNIR_SIZE.Width / 2 - 4)
			{
				actionMjolnir2Cap = true;
			}
			else if (count < 59 + 4)
			{
				actionHandUp = true;
			}
			else if (count < 63 + 1)
			{
				actionMjolnirStraight = true;
			}
			else if (count < 64 + 5)
			{
				timer.Interval = 350;
				actionLightnings[0] = true;
			}
			else if (count < 69 + 1)
			{
				timer.Interval = 1;
				actionMjolnirRotate2 = true;
			}
			else if (count < 70 + 10)
			{
				timer1.Stop();
				timer.Interval = 190;
				actionShootIronMan = true;
			}
			else if (count < 80 + 5)
			{
				actionShootIronMan2 = true;
			}
			else if (count < 85 + 1)
			{
				timer.Interval = 1;
				actionIronGetHit = true;
			}
			else if (count < 86 + 1)
			{
				actionHumanHandDown = true;
			}
			else if (count < 87 + 2)
			{
				timer.Interval = 300;
				actionKamehamehaCharge = true;
			}
			else if (count < 89 + 1)
			{
				actionKamehamehaGo1 = true;
			}
			else if (count < 90 + 1)
			{
				actionKamehamehaGo2 = true;
			}

			if (isDraw)
			{
				pbDrawingArea.Refresh();
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (count % 2 == 0)
			{
				ironManUp = true;
			}
			else
			{
				ironManDown = true;
			}
		}
	}
}