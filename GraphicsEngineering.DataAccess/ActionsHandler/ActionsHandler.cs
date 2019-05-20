using System;
using System.Drawing;
using System.Windows.Forms;
using GraphicsEngineering.DataAccess.Common;
using GraphicsEngineering.DataAccess.Models;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Threading;

namespace GraphicsEngineering.DataAccess.ActionsHandler
{
	public class ActionsHandler : IDisposable
	{
		public int MAXSPEED { get; } = 1000;
		public Control DrawingArea { get; set; }
		public Shape Shape { get; set; }
		private Timer _timer;

		private bool isTranslating = false;
		private bool isRotate = false;

		private int _speed;
		private Point _origin;
		public int Speed
		{
			get { return _speed; }
			set
			{
				if (value > MAXSPEED) _speed = MAXSPEED;
				else if (value <= 0) _speed = 1;
				else _speed = value;
			}
		}
		public int TranslatingX { get; set; }
		public int TranslatingY { get; set; }
		public int Angle { get; set; }
		public Point Origin
		{
			get { return _origin; }
			set { _origin = value.ToComputerCoordinates(DrawingArea.Width, DrawingArea.Height); }
		}

		public ActionsHandler(PictureBox drawingArea)
		{
			DrawingArea = drawingArea;
			DrawingArea.Paint += DrawingArea_Paint;
		}

		private void DrawingArea_Paint(object sender, PaintEventArgs e)
		{
			//e.Graphics tự hủy sau khi vẽ => ko cần dispose
			if (isTranslating)
			{
				Shape.Draw(e.Graphics, Dashes.Solid);
				Shape.TranslatingTransform(TranslatingX, TranslatingY);
			}
			if (isRotate)
			{
				Shape.Draw(e.Graphics, Dashes.Solid);
				Shape.RotateTransform(_origin, Angle);
			}
			isTranslating = false;
			isRotate = false;
		}

		public void Translating(Control coordinatesArea)
		{
			// Interval < 70 dễ lỗi
			_timer = new Timer(1070 - _speed);
			_timer.Elapsed += new ElapsedEventHandler((object o, ElapsedEventArgs e) =>
			{
				isTranslating = true;
				coordinatesArea.Invoke(new Action(() => coordinatesArea.Text = Shape.ToString()));
				DrawingArea.Invoke(new Action(() => DrawingArea.Refresh()));
			});
			_timer.Start();
		}
		public void Rotate(Control coordinatesArea)
		{
			// Interval < 70 dễ lỗi
			_timer = new Timer(1070 - _speed);
			_timer.Elapsed += new ElapsedEventHandler((object o, ElapsedEventArgs e) =>
			{
				isRotate = true;
				coordinatesArea.Invoke(new Action(() => coordinatesArea.Text = Shape.ToString()));
				DrawingArea.Invoke(new Action(() => DrawingArea.Refresh()));
			});
			_timer.Start();
		}

		public void Dispose()
		{
			Stop();
			//Thread.Sleep(40);
			_timer?.Dispose();
			//Shape?.Dispose();
		}
		public void Stop()
		{
			_timer?.Stop();
		}
	}
}
