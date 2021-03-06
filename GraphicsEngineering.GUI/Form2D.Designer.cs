﻿namespace GraphicsEngineering.GUI
{
	partial class Form2D
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.pnMenuBar = new System.Windows.Forms.Panel();
            this.lblScreenResolution = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimaze = new System.Windows.Forms.Label();
            this.grbCoordinates = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbScreen = new System.Windows.Forms.GroupBox();
            this.ckbGridDraw = new GraphicsEngineering.GUI.MyCheckBox();
            this.pbDrawingArea = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMenuBar.SuspendLayout();
            this.grbCoordinates.SuspendLayout();
            this.grbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuBar
            // 
            this.pnMenuBar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnMenuBar.Controls.Add(this.lblScreenResolution);
            this.pnMenuBar.Controls.Add(this.lblClose);
            this.pnMenuBar.Controls.Add(this.lblMinimaze);
            this.pnMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnMenuBar.Name = "pnMenuBar";
            this.pnMenuBar.Size = new System.Drawing.Size(1318, 30);
            this.pnMenuBar.TabIndex = 4;
            // 
            // lblScreenResolution
            // 
            this.lblScreenResolution.AutoSize = true;
            this.lblScreenResolution.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblScreenResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenResolution.Location = new System.Drawing.Point(0, 0);
            this.lblScreenResolution.Name = "lblScreenResolution";
            this.lblScreenResolution.Size = new System.Drawing.Size(137, 20);
            this.lblScreenResolution.TabIndex = 2;
            this.lblScreenResolution.Text = "Screen resolution:";
            this.lblScreenResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.BackColor = System.Drawing.Color.SteelBlue;
            this.lblClose.Image = global::GraphicsEngineering.GUI.Properties.Resources.closeRound;
            this.lblClose.Location = new System.Drawing.Point(1289, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 28);
            this.lblClose.TabIndex = 1;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMinimaze
            // 
            this.lblMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimaze.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMinimaze.Image = global::GraphicsEngineering.GUI.Properties.Resources.minimizeRound;
            this.lblMinimaze.Location = new System.Drawing.Point(1261, 0);
            this.lblMinimaze.Name = "lblMinimaze";
            this.lblMinimaze.Size = new System.Drawing.Size(28, 28);
            this.lblMinimaze.TabIndex = 0;
            this.lblMinimaze.Click += new System.EventHandler(this.lblMinimaze_Click);
            // 
            // grbCoordinates
            // 
            this.grbCoordinates.Controls.Add(this.txtInfo);
            this.grbCoordinates.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCoordinates.Location = new System.Drawing.Point(1055, 30);
            this.grbCoordinates.Name = "grbCoordinates";
            this.grbCoordinates.Size = new System.Drawing.Size(263, 607);
            this.grbCoordinates.TabIndex = 2;
            this.grbCoordinates.TabStop = false;
            this.grbCoordinates.Text = "Coordinates";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(3, 16);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(257, 588);
            this.txtInfo.TabIndex = 0;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPause.Location = new System.Drawing.Point(886, 572);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(57, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPlay.Location = new System.Drawing.Point(787, 572);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Location = new System.Drawing.Point(714, 572);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(57, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbScreen
            // 
            this.grbScreen.Controls.Add(this.btnReset);
            this.grbScreen.Controls.Add(this.btnPlay);
            this.grbScreen.Controls.Add(this.btnPause);
            this.grbScreen.Controls.Add(this.ckbGridDraw);
            this.grbScreen.Controls.Add(this.pbDrawingArea);
            this.grbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbScreen.Location = new System.Drawing.Point(0, 30);
            this.grbScreen.Name = "grbScreen";
            this.grbScreen.Size = new System.Drawing.Size(1055, 607);
            this.grbScreen.TabIndex = 3;
            this.grbScreen.TabStop = false;
            this.grbScreen.Text = "Screen";
            // 
            // ckbGridDraw
            // 
            this.ckbGridDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbGridDraw.BackColor = System.Drawing.Color.Transparent;
            this.ckbGridDraw.Location = new System.Drawing.Point(994, 576);
            this.ckbGridDraw.Name = "ckbGridDraw";
            this.ckbGridDraw.Padding = new System.Windows.Forms.Padding(3);
            this.ckbGridDraw.Size = new System.Drawing.Size(58, 28);
            this.ckbGridDraw.TabIndex = 3;
            this.ckbGridDraw.Text = "myCheckBox1";
            this.ckbGridDraw.UseVisualStyleBackColor = false;
            this.ckbGridDraw.CheckedChanged += new System.EventHandler(this.ckbGridDraw_CheckedChanged);
            // 
            // pbDrawingArea
            // 
            this.pbDrawingArea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbDrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawingArea.Location = new System.Drawing.Point(3, 16);
            this.pbDrawingArea.Name = "pbDrawingArea";
            this.pbDrawingArea.Size = new System.Drawing.Size(1049, 588);
            this.pbDrawingArea.TabIndex = 0;
            this.pbDrawingArea.TabStop = false;
            this.pbDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDrawingArea_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1318, 637);
            this.Controls.Add(this.grbScreen);
            this.Controls.Add(this.grbCoordinates);
            this.Controls.Add(this.pnMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2D";
            this.Text = "Graphics Engineering";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form2D_Load);
            this.pnMenuBar.ResumeLayout(false);
            this.pnMenuBar.PerformLayout();
            this.grbCoordinates.ResumeLayout(false);
            this.grbCoordinates.PerformLayout();
            this.grbScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingArea)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		private System.Windows.Forms.Panel pnMenuBar;
		private System.Windows.Forms.Label lblMinimaze;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.GroupBox grbCoordinates;
		private System.Windows.Forms.GroupBox grbScreen;
		private System.Windows.Forms.PictureBox pbDrawingArea;
		private MyCheckBox ckbGridDraw;
		private System.Windows.Forms.Label lblScreenResolution;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.TextBox txtInfo;
	}
}

