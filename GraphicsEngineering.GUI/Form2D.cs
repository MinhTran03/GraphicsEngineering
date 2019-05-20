﻿using System;
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
		private bool isDrawLine2 = true;

		public Form2D()
		{
			InitializeComponent();
		}

		private void Form2D_Load(object sender, EventArgs e)
		{
			Constant.WIDTH_DRAWING_AREA = pbDrawingArea.Width;
			Constant.HEIGHT_DRAWING_AREA = pbDrawingArea.Height;
			grid = new Grid(pbDrawingArea);
			Rectangle rect = new Rectangle(-15, 50, 30, 30);

			line = new Line(new Point(0, 0), new Point(20, 20));
			line2 = new Line(new Point(0, 20), new Point(20, 20));
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
			shapes.ForEach(shape => shape?.Dispose());
		}

		private void pbDrawingArea_MouseDown(object sender, MouseEventArgs e)
		{
		}

		private void pbDrawingArea_Paint(object sender, PaintEventArgs e)
		{
			if (isDrawLine2)
			{
				line2.Draw(e.Graphics);
				line2.TranslatingTransform(1, 0);
				line.Draw(e.Graphics);
				lblInfo1.Text = line.ToString();
			}
			isDrawLine2 = false;
		}
	}
}