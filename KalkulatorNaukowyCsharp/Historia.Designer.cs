namespace KalkulatorNaukowyCsharp
{
    partial class Historia
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
            this.HistoryTxt = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Label();
            this.ClearHistory = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryTxt
            // 
            this.HistoryTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HistoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryTxt.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HistoryTxt.ForeColor = System.Drawing.Color.White;
            this.HistoryTxt.Location = new System.Drawing.Point(0, 49);
            this.HistoryTxt.Name = "HistoryTxt";
            this.HistoryTxt.Size = new System.Drawing.Size(360, 524);
            this.HistoryTxt.TabIndex = 0;
            this.HistoryTxt.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.H);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 51);
            this.panel1.TabIndex = 1;
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
            this.Exit.Location = new System.Drawing.Point(307, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 48);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.H.ForeColor = System.Drawing.Color.White;
            this.H.Location = new System.Drawing.Point(3, 9);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(121, 32);
            this.H.TabIndex = 60;
            this.H.Text = "Historia:";
            // 
            // ClearHistory
            // 
            this.ClearHistory.AutoSize = true;
            this.ClearHistory.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ClearHistory.ForeColor = System.Drawing.Color.Aqua;
            this.ClearHistory.Location = new System.Drawing.Point(12, 19);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(191, 29);
            this.ClearHistory.TabIndex = 61;
            this.ClearHistory.TabStop = true;
            this.ClearHistory.Text = "Wyczyść historię ";
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.CheckedChanged += new System.EventHandler(this.ClearHistory_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.ClearHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 60);
            this.panel2.TabIndex = 62;
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HistoryTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Historia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HistoryTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton ClearHistory;
        private System.Windows.Forms.Panel panel2;
    }
}