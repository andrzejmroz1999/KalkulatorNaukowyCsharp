namespace KalkulatorNaukowyCsharp
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Precision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IndexE = new System.Windows.Forms.TextBox();
            this.IndexS = new System.Windows.Forms.TextBox();
            this.z4 = new System.Windows.Forms.TextBox();
            this.z3 = new System.Windows.Forms.TextBox();
            this.z2 = new System.Windows.Forms.TextBox();
            this.z1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.Draw = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.TextBox();
            this.pi = new System.Windows.Forms.TextBox();
            this.drawOther = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.otherX = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.other = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.Txt);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 56);
            this.panel1.TabIndex = 0;
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Font = new System.Drawing.Font("Cambria", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt.Location = new System.Drawing.Point(3, 9);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(451, 41);
            this.Txt.TabIndex = 43;
            this.Txt.Text = "Rysowanie wykresu funkcji:";
            this.Txt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseMove);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::KalkulatorNaukowyCsharp.Properties.Resources.cl1;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(1490, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 51);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Precision);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.IndexE);
            this.panel2.Controls.Add(this.IndexS);
            this.panel2.Controls.Add(this.z4);
            this.panel2.Controls.Add(this.z3);
            this.panel2.Controls.Add(this.z2);
            this.panel2.Controls.Add(this.z1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.c);
            this.panel2.Controls.Add(this.x4);
            this.panel2.Controls.Add(this.X);
            this.panel2.Controls.Add(this.x2);
            this.panel2.Controls.Add(this.x3);
            this.panel2.Controls.Add(this.Draw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1546, 61);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1188, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 32);
            this.label8.TabIndex = 70;
            this.label8.Text = ":";
            // 
            // Precision
            // 
            this.Precision.BackColor = System.Drawing.Color.Indigo;
            this.Precision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Precision.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Precision.ForeColor = System.Drawing.Color.White;
            this.Precision.Location = new System.Drawing.Point(885, 29);
            this.Precision.Multiline = true;
            this.Precision.Name = "Precision";
            this.Precision.Size = new System.Drawing.Size(195, 32);
            this.Precision.TabIndex = 69;
            this.Precision.Text = "0,001";
            this.Precision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precision_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(946, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 68;
            this.label7.Text = "precyzja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1117, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "Przedniał x:";
            // 
            // IndexE
            // 
            this.IndexE.BackColor = System.Drawing.Color.Indigo;
            this.IndexE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndexE.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.IndexE.ForeColor = System.Drawing.Color.White;
            this.IndexE.Location = new System.Drawing.Point(1211, 29);
            this.IndexE.Multiline = true;
            this.IndexE.Name = "IndexE";
            this.IndexE.Size = new System.Drawing.Size(76, 29);
            this.IndexE.TabIndex = 66;
            this.IndexE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndexE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndexE_KeyPress);
            // 
            // IndexS
            // 
            this.IndexS.BackColor = System.Drawing.Color.Indigo;
            this.IndexS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndexS.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.IndexS.ForeColor = System.Drawing.Color.White;
            this.IndexS.Location = new System.Drawing.Point(1110, 29);
            this.IndexS.Multiline = true;
            this.IndexS.Name = "IndexS";
            this.IndexS.Size = new System.Drawing.Size(76, 29);
            this.IndexS.TabIndex = 65;
            this.IndexS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndexS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndexS_KeyPress);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.Color.Indigo;
            this.z4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z4.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.z4.ForeColor = System.Drawing.Color.White;
            this.z4.Location = new System.Drawing.Point(489, 34);
            this.z4.Multiline = true;
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(17, 20);
            this.z4.TabIndex = 64;
            this.z4.Text = "+";
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.Indigo;
            this.z3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.z3.ForeColor = System.Drawing.Color.White;
            this.z3.Location = new System.Drawing.Point(365, 34);
            this.z3.Multiline = true;
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(17, 20);
            this.z3.TabIndex = 63;
            this.z3.Text = "+";
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.Indigo;
            this.z2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.z2.ForeColor = System.Drawing.Color.White;
            this.z2.Location = new System.Drawing.Point(234, 34);
            this.z2.Multiline = true;
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(17, 20);
            this.z2.TabIndex = 62;
            this.z2.Text = "+";
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.Indigo;
            this.z1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.z1.ForeColor = System.Drawing.Color.White;
            this.z1.Location = new System.Drawing.Point(98, 34);
            this.z1.Multiline = true;
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(17, 20);
            this.z1.TabIndex = 61;
            this.z1.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(556, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(425, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(291, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "x^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(153, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "x^3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "x^4";
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Indigo;
            this.c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(526, 32);
            this.c.Multiline = true;
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(76, 29);
            this.c.TabIndex = 56;
            this.c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_KeyPress);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.Color.Indigo;
            this.x4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x4.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x4.ForeColor = System.Drawing.Color.White;
            this.x4.Location = new System.Drawing.Point(4, 29);
            this.x4.Multiline = true;
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(76, 29);
            this.x4.TabIndex = 52;
            this.x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x4_KeyPress);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Indigo;
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.X.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(397, 32);
            this.X.Multiline = true;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(76, 29);
            this.X.TabIndex = 55;
            this.X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_KeyPress);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.Indigo;
            this.x2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x2.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.x2.ForeColor = System.Drawing.Color.White;
            this.x2.Location = new System.Drawing.Point(269, 30);
            this.x2.Multiline = true;
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(76, 29);
            this.x2.TabIndex = 54;
            this.x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x2_KeyPress);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.Indigo;
            this.x3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x3.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.x3.ForeColor = System.Drawing.Color.White;
            this.x3.Location = new System.Drawing.Point(137, 30);
            this.x3.Multiline = true;
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(76, 29);
            this.x3.TabIndex = 53;
            this.x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x3_KeyPress);
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.Color.Transparent;
            this.Draw.BackgroundImage = global::KalkulatorNaukowyCsharp.Properties.Resources.icons8_edit_filled_50;
            this.Draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Draw.FlatAppearance.BorderSize = 0;
            this.Draw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Draw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Draw.Location = new System.Drawing.Point(644, 7);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(53, 51);
            this.Draw.TabIndex = 44;
            this.Draw.UseVisualStyleBackColor = false;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.e);
            this.panel3.Controls.Add(this.pi);
            this.panel3.Controls.Add(this.drawOther);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.otherX);
            this.panel3.Controls.Add(this.hScrollBar1);
            this.panel3.Controls.Add(this.Wykres);
            this.panel3.Controls.Add(this.other);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1546, 549);
            this.panel3.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1356, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 32);
            this.label11.TabIndex = 75;
            this.label11.Text = "e";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1346, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 32);
            this.label10.TabIndex = 74;
            this.label10.Text = "pi";
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.Indigo;
            this.e.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.e.ForeColor = System.Drawing.Color.White;
            this.e.Location = new System.Drawing.Point(1409, 456);
            this.e.Multiline = true;
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(134, 29);
            this.e.TabIndex = 73;
            this.e.Text = "2,7182818284";
            this.e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.Indigo;
            this.pi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pi.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.pi.ForeColor = System.Drawing.Color.White;
            this.pi.Location = new System.Drawing.Point(1407, 421);
            this.pi.Multiline = true;
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(134, 29);
            this.pi.TabIndex = 72;
            this.pi.Text = "3,1415926535";
            this.pi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawOther
            // 
            this.drawOther.BackColor = System.Drawing.Color.Transparent;
            this.drawOther.BackgroundImage = global::KalkulatorNaukowyCsharp.Properties.Resources.icons8_edit_filled_50;
            this.drawOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawOther.FlatAppearance.BorderSize = 0;
            this.drawOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.drawOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.drawOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawOther.Location = new System.Drawing.Point(1393, 133);
            this.drawOther.Name = "drawOther";
            this.drawOther.Size = new System.Drawing.Size(53, 51);
            this.drawOther.TabIndex = 71;
            this.drawOther.UseVisualStyleBackColor = false;
            this.drawOther.Click += new System.EventHandler(this.drawOther_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1305, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 43);
            this.label9.TabIndex = 71;
            this.label9.Text = "x * :";
            // 
            // otherX
            // 
            this.otherX.BackColor = System.Drawing.Color.Indigo;
            this.otherX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherX.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.otherX.ForeColor = System.Drawing.Color.White;
            this.otherX.Location = new System.Drawing.Point(1397, 86);
            this.otherX.Multiline = true;
            this.otherX.Name = "otherX";
            this.otherX.Size = new System.Drawing.Size(134, 29);
            this.otherX.TabIndex = 71;
            this.otherX.Text = "1";
            this.otherX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otherX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otherX_KeyPress);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1110, 532);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(177, 17);
            this.hScrollBar1.TabIndex = 71;
            this.hScrollBar1.Value = 50;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Wykres
            // 
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(0, -3);
            this.Wykres.Name = "Wykres";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Cambria", 2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            series1.Legend = "Legend1";
            series1.Name = "Func";
            this.Wykres.Series.Add(series1);
            this.Wykres.Size = new System.Drawing.Size(1299, 550);
            this.Wykres.TabIndex = 0;
            this.Wykres.Text = "chart1";
            this.Wykres.Visible = false;
            // 
            // other
            // 
            this.other.BackColor = System.Drawing.Color.Indigo;
            this.other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.other.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.other.FormattingEnabled = true;
            this.other.Items.AddRange(new object[] {
            "Sin (x)",
            "Cos (x)",
            "Tan (x)",
            "Sinh (x)",
            "Cosh (x)",
            "Tanh (x)",
            "Log (x)",
            "Ln (x)",
            "a ^ (x)",
            "e ^ (x)",
            "sqrt (x)"});
            this.other.Location = new System.Drawing.Point(1302, 0);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(239, 40);
            this.other.TabIndex = 44;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Txt;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox z4;
        private System.Windows.Forms.TextBox z3;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.TextBox Precision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IndexE;
        private System.Windows.Forms.TextBox IndexS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ComboBox other;
        private System.Windows.Forms.TextBox otherX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button drawOther;
        private System.Windows.Forms.TextBox e;
        private System.Windows.Forms.TextBox pi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}