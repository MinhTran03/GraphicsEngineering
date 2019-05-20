namespace GraphicsEngineering.GUI
{
	partial class Form3D
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
            this.pnBar = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnControls = new System.Windows.Forms.Panel();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReviewColor = new System.Windows.Forms.Button();
            this.fpnColors = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnLightGray = new System.Windows.Forms.Button();
            this.btnDarkGray = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnDarkRed = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnLightYellow = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnLime = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnAqua = new System.Windows.Forms.Button();
            this.btnTurquoise = new System.Windows.Forms.Button();
            this.btnIndigo = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnRose = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.grbControls = new System.Windows.Forms.GroupBox();
            this.pnShapes = new System.Windows.Forms.Panel();
            this.inputPyramid = new GraphicsEngineering.GUI.InputPyramid();
            this.inputCube = new GraphicsEngineering.GUI.InputCube();
            this.btnSphere = new System.Windows.Forms.Button();
            this.btnSquarePyramid = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.fpnButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnCoordinates = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbDrawingArea = new System.Windows.Forms.PictureBox();
            this.pnBar.SuspendLayout();
            this.pnControls.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.fpnColors.SuspendLayout();
            this.grbControls.SuspendLayout();
            this.pnShapes.SuspendLayout();
            this.fpnButton.SuspendLayout();
            this.pnCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.pnBar.Controls.Add(this.lblMinimize);
            this.pnBar.Controls.Add(this.lblClose);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(1251, 28);
            this.pnBar.TabIndex = 0;
            // 
            // lblMinimize
            // 
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Image = global::GraphicsEngineering.GUI.Properties.Resources.minimizeLong;
            this.lblMinimize.Location = new System.Drawing.Point(1151, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(50, 28);
            this.lblMinimize.TabIndex = 0;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Image = global::GraphicsEngineering.GUI.Properties.Resources.closeLong;
            this.lblClose.Location = new System.Drawing.Point(1201, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(50, 28);
            this.lblClose.TabIndex = 1;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // pnControls
            // 
            this.pnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.pnControls.Controls.Add(this.grbColor);
            this.pnControls.Controls.Add(this.grbControls);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.pnControls.Location = new System.Drawing.Point(919, 28);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(332, 672);
            this.pnControls.TabIndex = 3;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.button1);
            this.grbColor.Controls.Add(this.btnReviewColor);
            this.grbColor.Controls.Add(this.fpnColors);
            this.grbColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbColor.Location = new System.Drawing.Point(0, 325);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(332, 248);
            this.grbColor.TabIndex = 1;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.button1.BackgroundImage = global::GraphicsEngineering.GUI.Properties.Resources.brush_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(220, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 49);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnReviewColor
            // 
            this.btnReviewColor.BackColor = System.Drawing.Color.Transparent;
            this.btnReviewColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReviewColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewColor.ForeColor = System.Drawing.Color.DimGray;
            this.btnReviewColor.Location = new System.Drawing.Point(3, 34);
            this.btnReviewColor.Name = "btnReviewColor";
            this.btnReviewColor.Size = new System.Drawing.Size(213, 49);
            this.btnReviewColor.TabIndex = 0;
            this.btnReviewColor.UseVisualStyleBackColor = false;
            // 
            // fpnColors
            // 
            this.fpnColors.Controls.Add(this.btnWhite);
            this.fpnColors.Controls.Add(this.btnLightGray);
            this.fpnColors.Controls.Add(this.btnDarkGray);
            this.fpnColors.Controls.Add(this.btnBlack);
            this.fpnColors.Controls.Add(this.btnDarkRed);
            this.fpnColors.Controls.Add(this.btnRed);
            this.fpnColors.Controls.Add(this.btnOrange);
            this.fpnColors.Controls.Add(this.btnGold);
            this.fpnColors.Controls.Add(this.btnLightYellow);
            this.fpnColors.Controls.Add(this.btnYellow);
            this.fpnColors.Controls.Add(this.btnLime);
            this.fpnColors.Controls.Add(this.btnGreen);
            this.fpnColors.Controls.Add(this.btnAqua);
            this.fpnColors.Controls.Add(this.btnTurquoise);
            this.fpnColors.Controls.Add(this.btnIndigo);
            this.fpnColors.Controls.Add(this.btnPink);
            this.fpnColors.Controls.Add(this.btnRose);
            this.fpnColors.Controls.Add(this.btnBrown);
            this.fpnColors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnColors.ForeColor = System.Drawing.Color.DimGray;
            this.fpnColors.Location = new System.Drawing.Point(3, 83);
            this.fpnColors.Name = "fpnColors";
            this.fpnColors.Size = new System.Drawing.Size(326, 162);
            this.fpnColors.TabIndex = 2;
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.ForeColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(3, 3);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(48, 48);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnLightGray
            // 
            this.btnLightGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLightGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightGray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLightGray.Location = new System.Drawing.Point(57, 3);
            this.btnLightGray.Name = "btnLightGray";
            this.btnLightGray.Size = new System.Drawing.Size(48, 48);
            this.btnLightGray.TabIndex = 1;
            this.btnLightGray.UseVisualStyleBackColor = false;
            this.btnLightGray.Click += new System.EventHandler(this.btnLightGray_Click);
            // 
            // btnDarkGray
            // 
            this.btnDarkGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnDarkGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkGray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnDarkGray.Location = new System.Drawing.Point(111, 3);
            this.btnDarkGray.Name = "btnDarkGray";
            this.btnDarkGray.Size = new System.Drawing.Size(48, 48);
            this.btnDarkGray.TabIndex = 2;
            this.btnDarkGray.UseVisualStyleBackColor = false;
            this.btnDarkGray.Click += new System.EventHandler(this.btnDarkGray_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.ForeColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(165, 3);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(48, 48);
            this.btnBlack.TabIndex = 3;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnDarkRed
            // 
            this.btnDarkRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(27)))));
            this.btnDarkRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(27)))));
            this.btnDarkRed.Location = new System.Drawing.Point(219, 3);
            this.btnDarkRed.Name = "btnDarkRed";
            this.btnDarkRed.Size = new System.Drawing.Size(48, 48);
            this.btnDarkRed.TabIndex = 4;
            this.btnDarkRed.UseVisualStyleBackColor = false;
            this.btnDarkRed.Click += new System.EventHandler(this.btnDarkRed_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnRed.Location = new System.Drawing.Point(273, 3);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(48, 48);
            this.btnRed.TabIndex = 5;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.btnOrange.Location = new System.Drawing.Point(3, 57);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(48, 48);
            this.btnOrange.TabIndex = 6;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(24)))));
            this.btnGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(24)))));
            this.btnGold.Location = new System.Drawing.Point(57, 57);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(48, 48);
            this.btnGold.TabIndex = 7;
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnLightYellow
            // 
            this.btnLightYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.btnLightYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightYellow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.btnLightYellow.Location = new System.Drawing.Point(111, 57);
            this.btnLightYellow.Name = "btnLightYellow";
            this.btnLightYellow.Size = new System.Drawing.Size(48, 48);
            this.btnLightYellow.TabIndex = 8;
            this.btnLightYellow.UseVisualStyleBackColor = false;
            this.btnLightYellow.Click += new System.EventHandler(this.btnLightYellow_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btnYellow.Location = new System.Drawing.Point(165, 57);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(48, 48);
            this.btnYellow.TabIndex = 9;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnLime
            // 
            this.btnLime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(14)))));
            this.btnLime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(14)))));
            this.btnLime.Location = new System.Drawing.Point(219, 57);
            this.btnLime.Name = "btnLime";
            this.btnLime.Size = new System.Drawing.Size(48, 48);
            this.btnLime.TabIndex = 10;
            this.btnLime.UseVisualStyleBackColor = false;
            this.btnLime.Click += new System.EventHandler(this.btnLime_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(209)))), ((int)(((byte)(69)))));
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(209)))), ((int)(((byte)(69)))));
            this.btnGreen.Location = new System.Drawing.Point(273, 57);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(48, 48);
            this.btnGreen.TabIndex = 11;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnAqua
            // 
            this.btnAqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.btnAqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.btnAqua.Location = new System.Drawing.Point(3, 111);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(48, 48);
            this.btnAqua.TabIndex = 12;
            this.btnAqua.UseVisualStyleBackColor = false;
            this.btnAqua.Click += new System.EventHandler(this.btnAqua_Click);
            // 
            // btnTurquoise
            // 
            this.btnTurquoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btnTurquoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurquoise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btnTurquoise.Location = new System.Drawing.Point(57, 111);
            this.btnTurquoise.Name = "btnTurquoise";
            this.btnTurquoise.Size = new System.Drawing.Size(48, 48);
            this.btnTurquoise.TabIndex = 13;
            this.btnTurquoise.UseVisualStyleBackColor = false;
            this.btnTurquoise.Click += new System.EventHandler(this.btnTurquoise_Click);
            // 
            // btnIndigo
            // 
            this.btnIndigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.btnIndigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.btnIndigo.Location = new System.Drawing.Point(111, 111);
            this.btnIndigo.Name = "btnIndigo";
            this.btnIndigo.Size = new System.Drawing.Size(48, 48);
            this.btnIndigo.TabIndex = 14;
            this.btnIndigo.UseVisualStyleBackColor = false;
            this.btnIndigo.Click += new System.EventHandler(this.btnTurquoise_Click);
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(186)))));
            this.btnPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(186)))));
            this.btnPink.Location = new System.Drawing.Point(165, 111);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(48, 48);
            this.btnPink.TabIndex = 15;
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnTurquoise_Click);
            // 
            // btnRose
            // 
            this.btnRose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(200)))));
            this.btnRose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(200)))));
            this.btnRose.Location = new System.Drawing.Point(219, 111);
            this.btnRose.Name = "btnRose";
            this.btnRose.Size = new System.Drawing.Size(48, 48);
            this.btnRose.TabIndex = 16;
            this.btnRose.UseVisualStyleBackColor = false;
            this.btnRose.Click += new System.EventHandler(this.btnTurquoise_Click);
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(86)))));
            this.btnBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(86)))));
            this.btnBrown.Location = new System.Drawing.Point(273, 111);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(48, 48);
            this.btnBrown.TabIndex = 17;
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.btnTurquoise_Click);
            // 
            // grbControls
            // 
            this.grbControls.Controls.Add(this.pnShapes);
            this.grbControls.Controls.Add(this.fpnButton);
            this.grbControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbControls.Location = new System.Drawing.Point(0, 0);
            this.grbControls.Name = "grbControls";
            this.grbControls.Size = new System.Drawing.Size(332, 325);
            this.grbControls.TabIndex = 0;
            this.grbControls.TabStop = false;
            this.grbControls.Text = "Shapes";
            // 
            // pnShapes
            // 
            this.pnShapes.Controls.Add(this.inputPyramid);
            this.pnShapes.Controls.Add(this.inputCube);
            this.pnShapes.Controls.Add(this.btnSphere);
            this.pnShapes.Controls.Add(this.btnSquarePyramid);
            this.pnShapes.Controls.Add(this.btnCube);
            this.pnShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnShapes.Location = new System.Drawing.Point(3, 34);
            this.pnShapes.Name = "pnShapes";
            this.pnShapes.Size = new System.Drawing.Size(326, 253);
            this.pnShapes.TabIndex = 0;
            // 
            // inputPyramid
            // 
            this.inputPyramid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.inputPyramid.Location = new System.Drawing.Point(3, 104);
            this.inputPyramid.Name = "inputPyramid";
            this.inputPyramid.Size = new System.Drawing.Size(318, 146);
            this.inputPyramid.TabIndex = 6;
            this.inputPyramid.Visible = false;
            // 
            // inputCube
            // 
            this.inputCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.inputCube.Location = new System.Drawing.Point(3, 107);
            this.inputCube.Name = "inputCube";
            this.inputCube.Size = new System.Drawing.Size(318, 146);
            this.inputCube.TabIndex = 3;
            this.inputCube.Visible = false;
            // 
            // btnSphere
            // 
            this.btnSphere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.btnSphere.BackgroundImage = global::GraphicsEngineering.GUI.Properties.Resources.sphereGray;
            this.btnSphere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSphere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSphere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnSphere.Location = new System.Drawing.Point(219, 3);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(102, 102);
            this.btnSphere.TabIndex = 2;
            this.btnSphere.UseVisualStyleBackColor = false;
            // 
            // btnSquarePyramid
            // 
            this.btnSquarePyramid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.btnSquarePyramid.BackgroundImage = global::GraphicsEngineering.GUI.Properties.Resources.squarePyramidGray;
            this.btnSquarePyramid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquarePyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquarePyramid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnSquarePyramid.Location = new System.Drawing.Point(111, 3);
            this.btnSquarePyramid.Name = "btnSquarePyramid";
            this.btnSquarePyramid.Size = new System.Drawing.Size(102, 102);
            this.btnSquarePyramid.TabIndex = 1;
            this.btnSquarePyramid.UseVisualStyleBackColor = false;
            this.btnSquarePyramid.Click += new System.EventHandler(this.btnSquarePyramid_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.btnCube.BackgroundImage = global::GraphicsEngineering.GUI.Properties.Resources.cubeGray;
            this.btnCube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnCube.Location = new System.Drawing.Point(3, 3);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(102, 102);
            this.btnCube.TabIndex = 0;
            this.btnCube.UseVisualStyleBackColor = false;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // fpnButton
            // 
            this.fpnButton.Controls.Add(this.btnDraw);
            this.fpnButton.Controls.Add(this.btnClear);
            this.fpnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnButton.Location = new System.Drawing.Point(3, 287);
            this.fpnButton.Name = "fpnButton";
            this.fpnButton.Size = new System.Drawing.Size(326, 35);
            this.fpnButton.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.Black;
            this.btnDraw.Location = new System.Drawing.Point(3, 3);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 30);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(84, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnCoordinates
            // 
            this.pnCoordinates.Controls.Add(this.lblInfo);
            this.pnCoordinates.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCoordinates.Location = new System.Drawing.Point(0, 28);
            this.pnCoordinates.Name = "pnCoordinates";
            this.pnCoordinates.Size = new System.Drawing.Size(536, 672);
            this.pnCoordinates.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(536, 672);
            this.lblInfo.TabIndex = 0;
            // 
            // pbDrawingArea
            // 
            this.pbDrawingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pbDrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawingArea.Location = new System.Drawing.Point(536, 28);
            this.pbDrawingArea.Name = "pbDrawingArea";
            this.pbDrawingArea.Size = new System.Drawing.Size(383, 672);
            this.pbDrawingArea.TabIndex = 4;
            this.pbDrawingArea.TabStop = false;
            // 
            // Form3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1251, 700);
            this.Controls.Add(this.pbDrawingArea);
            this.Controls.Add(this.pnCoordinates);
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.pnBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3D_Load);
            this.pnBar.ResumeLayout(false);
            this.pnControls.ResumeLayout(false);
            this.grbColor.ResumeLayout(false);
            this.fpnColors.ResumeLayout(false);
            this.grbControls.ResumeLayout(false);
            this.pnShapes.ResumeLayout(false);
            this.fpnButton.ResumeLayout(false);
            this.pnCoordinates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingArea)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnBar;
		private System.Windows.Forms.Panel pnControls;
		private System.Windows.Forms.Button btnSquarePyramid;
		private System.Windows.Forms.Button btnWhite;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.GroupBox grbControls;
		private System.Windows.Forms.GroupBox grbColor;
		private System.Windows.Forms.Button btnReviewColor;
		private System.Windows.Forms.FlowLayoutPanel fpnColors;
		private System.Windows.Forms.Button btnLightGray;
		private System.Windows.Forms.Button btnDarkGray;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.PictureBox pbDrawingArea;
		private System.Windows.Forms.Panel pnCoordinates;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Label lblMinimize;
		private System.Windows.Forms.Button btnBlack;
		private System.Windows.Forms.Button btnDarkRed;
		private System.Windows.Forms.Button btnRed;
		private System.Windows.Forms.FlowLayoutPanel fpnButton;
		private System.Windows.Forms.Button btnOrange;
		private System.Windows.Forms.Button btnGold;
		private System.Windows.Forms.Button btnLightYellow;
		private System.Windows.Forms.Button btnYellow;
		private System.Windows.Forms.Button btnLime;
		private System.Windows.Forms.Button btnGreen;
		private System.Windows.Forms.Button btnAqua;
		private System.Windows.Forms.Button btnTurquoise;
		private System.Windows.Forms.Button btnIndigo;
		private System.Windows.Forms.Button btnPink;
		private System.Windows.Forms.Button btnRose;
		private System.Windows.Forms.Button btnBrown;
		private System.Windows.Forms.Button btnSphere;
		private System.Windows.Forms.Button btnCube;
		private System.Windows.Forms.Panel pnShapes;
		private InputCube inputCube;
		private InputPyramid inputPyramid;
	}
}