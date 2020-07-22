namespace ZCA3
{
	partial class Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownNucX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownNucY = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDownRand1 = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.numericUpDownRand2 = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.numericUpDownRadiusNucleation = new System.Windows.Forms.NumericUpDown();
			this.NucleationButton = new System.Windows.Forms.Button();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDownRadiusNeighborhood = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.exportButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.buttonMonteCarlo = new System.Windows.Forms.Button();
			this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioButtonEnergy = new System.Windows.Forms.RadioButton();
			this.radioButtonEdges = new System.Windows.Forms.RadioButton();
			this.radioButtonNormal = new System.Windows.Forms.RadioButton();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.numericUpDownKT = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNucX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNucY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadiusNucleation)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadiusNeighborhood)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownKT)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
			this.pictureBox.Location = new System.Drawing.Point(364, 9);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(800, 738);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(12, 506);
			this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(176, 52);
			this.GenerateButton.TabIndex = 1;
			this.GenerateButton.Text = "Generuj mikrostrukturę";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(7, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Rozmiar przestrzeni";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(7, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(7, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "X:";
			// 
			// numericUpDownX
			// 
			this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDownX.Location = new System.Drawing.Point(35, 42);
			this.numericUpDownX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownX.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.numericUpDownX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownX.Name = "numericUpDownX";
			this.numericUpDownX.Size = new System.Drawing.Size(60, 23);
			this.numericUpDownX.TabIndex = 5;
			this.numericUpDownX.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDownX.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
			// 
			// numericUpDownY
			// 
			this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDownY.Location = new System.Drawing.Point(35, 70);
			this.numericUpDownY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownY.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.numericUpDownY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownY.Name = "numericUpDownY";
			this.numericUpDownY.Size = new System.Drawing.Size(60, 23);
			this.numericUpDownY.TabIndex = 6;
			this.numericUpDownY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDownY.ValueChanged += new System.EventHandler(this.NumericUpDownY_ValueChanged);
			// 
			// numericUpDownNucX
			// 
			this.numericUpDownNucX.Location = new System.Drawing.Point(122, 2);
			this.numericUpDownNucX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownNucX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDownNucX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownNucX.Name = "numericUpDownNucX";
			this.numericUpDownNucX.Size = new System.Drawing.Size(60, 23);
			this.numericUpDownNucX.TabIndex = 14;
			this.numericUpDownNucX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericUpDownNucY
			// 
			this.numericUpDownNucY.Location = new System.Drawing.Point(122, 32);
			this.numericUpDownNucY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownNucY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDownNucY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownNucY.Name = "numericUpDownNucY";
			this.numericUpDownNucY.Size = new System.Drawing.Size(60, 23);
			this.numericUpDownNucY.TabIndex = 13;
			this.numericUpDownNucY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Ilość w wierszu:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "Ilość w kolumnie:";
			// 
			// numericUpDownRand1
			// 
			this.numericUpDownRand1.Location = new System.Drawing.Point(52, 2);
			this.numericUpDownRand1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownRand1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownRand1.Name = "numericUpDownRand1";
			this.numericUpDownRand1.Size = new System.Drawing.Size(77, 23);
			this.numericUpDownRand1.TabIndex = 14;
			this.numericUpDownRand1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Ilość:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabControl1.Location = new System.Drawing.Point(11, 100);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(323, 89);
			this.tabControl1.TabIndex = 16;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.numericUpDownNucX);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.numericUpDownNucY);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Size = new System.Drawing.Size(315, 59);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Jednorodne";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.numericUpDownRand1);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Size = new System.Drawing.Size(315, 59);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Losowe";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.numericUpDownRand2);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.numericUpDownRadiusNucleation);
			this.tabPage3.Location = new System.Drawing.Point(4, 26);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage3.Size = new System.Drawing.Size(315, 59);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Losowe z promieniem";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// numericUpDownRand2
			// 
			this.numericUpDownRand2.Location = new System.Drawing.Point(69, 1);
			this.numericUpDownRand2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownRand2.Name = "numericUpDownRand2";
			this.numericUpDownRand2.Size = new System.Drawing.Size(81, 23);
			this.numericUpDownRand2.TabIndex = 18;
			this.numericUpDownRand2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 2);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 17);
			this.label9.TabIndex = 16;
			this.label9.Text = "Ilość:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 31);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 17);
			this.label10.TabIndex = 15;
			this.label10.Text = "Promień:";
			// 
			// numericUpDownRadiusNucleation
			// 
			this.numericUpDownRadiusNucleation.DecimalPlaces = 2;
			this.numericUpDownRadiusNucleation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownRadiusNucleation.Location = new System.Drawing.Point(69, 30);
			this.numericUpDownRadiusNucleation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownRadiusNucleation.Maximum = new decimal(new int[] {
            149,
            0,
            0,
            0});
			this.numericUpDownRadiusNucleation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDownRadiusNucleation.Name = "numericUpDownRadiusNucleation";
			this.numericUpDownRadiusNucleation.Size = new System.Drawing.Size(81, 23);
			this.numericUpDownRadiusNucleation.TabIndex = 17;
			this.numericUpDownRadiusNucleation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// NucleationButton
			// 
			this.NucleationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NucleationButton.Location = new System.Drawing.Point(11, 219);
			this.NucleationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NucleationButton.Name = "NucleationButton";
			this.NucleationButton.Size = new System.Drawing.Size(176, 52);
			this.NucleationButton.TabIndex = 17;
			this.NucleationButton.Text = "Stwórz zarodki";
			this.NucleationButton.UseVisualStyleBackColor = true;
			this.NucleationButton.Click += new System.EventHandler(this.NucleationButton_Click);
			// 
			// comboBox
			// 
			this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Items.AddRange(new object[] {
            "von Neumanna",
            "Moore\'a",
            "Pentagonalne",
            "Heksagonalne prawe",
            "Heksagonalne lewe",
            "Heksagonalne losowe",
            "Z promieniem",
            "Z promieniem i przesunięciem"});
			this.comboBox.Location = new System.Drawing.Point(11, 25);
			this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(176, 25);
			this.comboBox.TabIndex = 18;
			this.comboBox.Text = "von Neumanna";
			// 
			// checkBox
			// 
			this.checkBox.AutoSize = true;
			this.checkBox.Checked = true;
			this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBox.Location = new System.Drawing.Point(11, 193);
			this.checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(225, 21);
			this.checkBox.TabIndex = 19;
			this.checkBox.Text = "Periodyczne warunki brzegowe";
			this.checkBox.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.checkBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.NucleationButton);
			this.groupBox1.Controls.Add(this.numericUpDownX);
			this.groupBox1.Controls.Add(this.tabControl1);
			this.groupBox1.Controls.Add(this.numericUpDownY);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(16, 9);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(336, 288);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Zarodkowanie";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.numericUpDownRadiusNeighborhood);
			this.groupBox2.Controls.Add(this.comboBox);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox2.Location = new System.Drawing.Point(16, 319);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(336, 95);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sąsiedztwo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(7, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Promień:";
			// 
			// numericUpDownRadiusNeighborhood
			// 
			this.numericUpDownRadiusNeighborhood.DecimalPlaces = 2;
			this.numericUpDownRadiusNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDownRadiusNeighborhood.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownRadiusNeighborhood.Location = new System.Drawing.Point(76, 62);
			this.numericUpDownRadiusNeighborhood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownRadiusNeighborhood.Maximum = new decimal(new int[] {
            149,
            0,
            0,
            0});
			this.numericUpDownRadiusNeighborhood.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownRadiusNeighborhood.Name = "numericUpDownRadiusNeighborhood";
			this.numericUpDownRadiusNeighborhood.Size = new System.Drawing.Size(76, 23);
			this.numericUpDownRadiusNeighborhood.TabIndex = 19;
			this.numericUpDownRadiusNeighborhood.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(225, 580);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 17);
			this.label5.TabIndex = 20;
			this.label5.Text = "Generowanie...";
			this.label5.Visible = false;
			// 
			// exportButton
			// 
			this.exportButton.Location = new System.Drawing.Point(12, 563);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(176, 52);
			this.exportButton.TabIndex = 22;
			this.exportButton.Text = "Eksportuj";
			this.exportButton.UseVisualStyleBackColor = true;
			this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// buttonMonteCarlo
			// 
			this.buttonMonteCarlo.Enabled = false;
			this.buttonMonteCarlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.buttonMonteCarlo.Location = new System.Drawing.Point(194, 506);
			this.buttonMonteCarlo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonMonteCarlo.Name = "buttonMonteCarlo";
			this.buttonMonteCarlo.Size = new System.Drawing.Size(158, 52);
			this.buttonMonteCarlo.TabIndex = 24;
			this.buttonMonteCarlo.Text = "Generuj Monte Carlo";
			this.buttonMonteCarlo.UseVisualStyleBackColor = true;
			this.buttonMonteCarlo.Click += new System.EventHandler(this.ButtonMonteCarlo_Click);
			// 
			// numericUpDownIterations
			// 
			this.numericUpDownIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.numericUpDownIterations.Location = new System.Drawing.Point(71, 29);
			this.numericUpDownIterations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownIterations.Name = "numericUpDownIterations";
			this.numericUpDownIterations.Size = new System.Drawing.Size(60, 23);
			this.numericUpDownIterations.TabIndex = 15;
			this.numericUpDownIterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.numericUpDownKT);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.numericUpDownIterations);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox3.Location = new System.Drawing.Point(16, 422);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(336, 78);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Monte Carlo";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(7, 31);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 17);
			this.label11.TabIndex = 19;
			this.label11.Text = "Iteracje:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.radioButtonEnergy);
			this.groupBox4.Controls.Add(this.radioButtonEdges);
			this.groupBox4.Controls.Add(this.radioButtonNormal);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox4.Location = new System.Drawing.Point(14, 622);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(336, 68);
			this.groupBox4.TabIndex = 26;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Widok";
			// 
			// radioButtonEnergy
			// 
			this.radioButtonEnergy.AutoSize = true;
			this.radioButtonEnergy.Enabled = false;
			this.radioButtonEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.radioButtonEnergy.Location = new System.Drawing.Point(237, 26);
			this.radioButtonEnergy.Name = "radioButtonEnergy";
			this.radioButtonEnergy.Size = new System.Drawing.Size(78, 21);
			this.radioButtonEnergy.TabIndex = 2;
			this.radioButtonEnergy.Text = "Energia";
			this.radioButtonEnergy.UseVisualStyleBackColor = true;
			this.radioButtonEnergy.CheckedChanged += new System.EventHandler(this.RadioButtonEnergy_CheckedChanged);
			// 
			// radioButtonEdges
			// 
			this.radioButtonEdges.AutoSize = true;
			this.radioButtonEdges.Enabled = false;
			this.radioButtonEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.radioButtonEdges.Location = new System.Drawing.Point(109, 26);
			this.radioButtonEdges.Name = "radioButtonEdges";
			this.radioButtonEdges.Size = new System.Drawing.Size(122, 21);
			this.radioButtonEdges.TabIndex = 1;
			this.radioButtonEdges.Text = "Granice ziaren";
			this.radioButtonEdges.UseVisualStyleBackColor = true;
			this.radioButtonEdges.CheckedChanged += new System.EventHandler(this.RadioButtonEdges_CheckedChanged);
			// 
			// radioButtonNormal
			// 
			this.radioButtonNormal.AutoSize = true;
			this.radioButtonNormal.Checked = true;
			this.radioButtonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.radioButtonNormal.Location = new System.Drawing.Point(7, 26);
			this.radioButtonNormal.Name = "radioButtonNormal";
			this.radioButtonNormal.Size = new System.Drawing.Size(96, 21);
			this.radioButtonNormal.TabIndex = 0;
			this.radioButtonNormal.TabStop = true;
			this.radioButtonNormal.Text = "Bez granic";
			this.radioButtonNormal.UseVisualStyleBackColor = true;
			this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.RadioButtonNormal_CheckedChanged);
			// 
			// timer2
			// 
			this.timer2.Interval = 10;
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.Location = new System.Drawing.Point(150, 31);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(113, 17);
			this.label12.TabIndex = 20;
			this.label12.Text = "Współczynnik kt:";
			// 
			// numericUpDownKT
			// 
			this.numericUpDownKT.DecimalPlaces = 1;
			this.numericUpDownKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.numericUpDownKT.Location = new System.Drawing.Point(269, 29);
			this.numericUpDownKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numericUpDownKT.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.numericUpDownKT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownKT.Name = "numericUpDownKT";
			this.numericUpDownKT.Size = new System.Drawing.Size(60, 23);
			this.numericUpDownKT.TabIndex = 21;
			this.numericUpDownKT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1179, 752);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.buttonMonteCarlo);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.exportButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.pictureBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(1197, 799);
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generator mikrostruktur";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNucX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNucY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadiusNucleation)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadiusNeighborhood)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownKT)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownX;
		private System.Windows.Forms.NumericUpDown numericUpDownY;
		private System.Windows.Forms.NumericUpDown numericUpDownNucX;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownNucY;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDownRand1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.NumericUpDown numericUpDownRand2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numericUpDownRadiusNucleation;
		private System.Windows.Forms.Button NucleationButton;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.CheckBox checkBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownRadiusNeighborhood;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button exportButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button buttonMonteCarlo;
		private System.Windows.Forms.NumericUpDown numericUpDownIterations;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButtonEnergy;
		private System.Windows.Forms.RadioButton radioButtonEdges;
		private System.Windows.Forms.RadioButton radioButtonNormal;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.NumericUpDown numericUpDownKT;
		private System.Windows.Forms.Label label12;
	}
}

