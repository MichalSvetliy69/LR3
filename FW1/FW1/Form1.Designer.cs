﻿namespace FW1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Black_Button = new System.Windows.Forms.Button();
            this.Blue_Button = new System.Windows.Forms.Button();
            this.White_Button = new System.Windows.Forms.Button();
            this.Yellow_Button = new System.Windows.Forms.Button();
            this.Red_Button = new System.Windows.Forms.Button();
            this.Green_Button = new System.Windows.Forms.Button();
            this.Eraser_Buttob = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Brush1 = new System.Windows.Forms.Button();
            this.Brush3 = new System.Windows.Forms.Button();
            this.Brush4 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Brush2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.panel2);
            this.toolPanel.Controls.Add(this.Eraser_Buttob);
            this.toolPanel.Controls.Add(this.groupBox1);
            this.toolPanel.Controls.Add(this.menuStrip1);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(339, 621);
            this.toolPanel.TabIndex = 10;
            this.toolPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Black_Button);
            this.panel2.Controls.Add(this.Blue_Button);
            this.panel2.Controls.Add(this.White_Button);
            this.panel2.Controls.Add(this.Yellow_Button);
            this.panel2.Controls.Add(this.Red_Button);
            this.panel2.Controls.Add(this.Green_Button);
            this.panel2.Location = new System.Drawing.Point(12, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 39);
            this.panel2.TabIndex = 23;
            // 
            // Black_Button
            // 
            this.Black_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Black_Button.Image = global::FW1.Properties.Resources.MyBlack;
            this.Black_Button.Location = new System.Drawing.Point(2, 2);
            this.Black_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Black_Button.Name = "Black_Button";
            this.Black_Button.Size = new System.Drawing.Size(30, 34);
            this.Black_Button.TabIndex = 2;
            this.Black_Button.UseVisualStyleBackColor = true;
            this.Black_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Blue_Button
            // 
            this.Blue_Button.Image = global::FW1.Properties.Resources.MyBlue;
            this.Blue_Button.Location = new System.Drawing.Point(33, 2);
            this.Blue_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Blue_Button.Name = "Blue_Button";
            this.Blue_Button.Size = new System.Drawing.Size(32, 34);
            this.Blue_Button.TabIndex = 22;
            this.Blue_Button.UseVisualStyleBackColor = true;
            this.Blue_Button.Click += new System.EventHandler(this.button7_Click);
            // 
            // White_Button
            // 
            this.White_Button.Image = global::FW1.Properties.Resources.MyWhite;
            this.White_Button.Location = new System.Drawing.Point(171, 2);
            this.White_Button.Margin = new System.Windows.Forms.Padding(2);
            this.White_Button.Name = "White_Button";
            this.White_Button.Size = new System.Drawing.Size(28, 34);
            this.White_Button.TabIndex = 18;
            this.White_Button.UseVisualStyleBackColor = true;
            this.White_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Yellow_Button
            // 
            this.Yellow_Button.Image = global::FW1.Properties.Resources.MyYellow;
            this.Yellow_Button.Location = new System.Drawing.Point(138, 2);
            this.Yellow_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Yellow_Button.Name = "Yellow_Button";
            this.Yellow_Button.Size = new System.Drawing.Size(29, 34);
            this.Yellow_Button.TabIndex = 19;
            this.Yellow_Button.UseVisualStyleBackColor = true;
            this.Yellow_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Red_Button
            // 
            this.Red_Button.Image = global::FW1.Properties.Resources.MyRed;
            this.Red_Button.Location = new System.Drawing.Point(102, 2);
            this.Red_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Red_Button.Name = "Red_Button";
            this.Red_Button.Size = new System.Drawing.Size(32, 34);
            this.Red_Button.TabIndex = 20;
            this.Red_Button.UseVisualStyleBackColor = true;
            this.Red_Button.Click += new System.EventHandler(this.button5_Click);
            // 
            // Green_Button
            // 
            this.Green_Button.Image = global::FW1.Properties.Resources.MyGreen;
            this.Green_Button.Location = new System.Drawing.Point(67, 2);
            this.Green_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Green_Button.Name = "Green_Button";
            this.Green_Button.Size = new System.Drawing.Size(31, 34);
            this.Green_Button.TabIndex = 21;
            this.Green_Button.UseVisualStyleBackColor = true;
            this.Green_Button.Click += new System.EventHandler(this.button6_Click);
            // 
            // Eraser_Buttob
            // 
            this.Eraser_Buttob.BackgroundImage = global::FW1.Properties.Resources._1654331157_4_flomaster_club_p_lastik_risunok_dlya_detei_krasivo_44;
            this.Eraser_Buttob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Eraser_Buttob.Location = new System.Drawing.Point(12, 401);
            this.Eraser_Buttob.Name = "Eraser_Buttob";
            this.Eraser_Buttob.Size = new System.Drawing.Size(52, 38);
            this.Eraser_Buttob.TabIndex = 5;
            this.Eraser_Buttob.UseVisualStyleBackColor = true;
            this.Eraser_Buttob.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Brush1);
            this.groupBox1.Controls.Add(this.Brush3);
            this.groupBox1.Controls.Add(this.Brush4);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.Brush2);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор кисти";
            // 
            // Brush1
            // 
            this.Brush1.BackgroundImage = global::FW1.Properties.Resources.Brush3;
            this.Brush1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brush1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brush1.Location = new System.Drawing.Point(12, 80);
            this.Brush1.Name = "Brush1";
            this.Brush1.Size = new System.Drawing.Size(52, 50);
            this.Brush1.TabIndex = 1;
            this.Brush1.UseVisualStyleBackColor = true;
            this.Brush1.Click += new System.EventHandler(this.brush1_Click);
            // 
            // Brush3
            // 
            this.Brush3.BackgroundImage = global::FW1.Properties.Resources.Brush1;
            this.Brush3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brush3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brush3.Location = new System.Drawing.Point(146, 80);
            this.Brush3.Name = "Brush3";
            this.Brush3.Size = new System.Drawing.Size(50, 50);
            this.Brush3.TabIndex = 4;
            this.Brush3.UseVisualStyleBackColor = true;
            this.Brush3.Click += new System.EventHandler(this.Brush4_Click);
            // 
            // Brush4
            // 
            this.Brush4.BackgroundImage = global::FW1.Properties.Resources.Brush4;
            this.Brush4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brush4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brush4.Location = new System.Drawing.Point(215, 80);
            this.Brush4.Name = "Brush4";
            this.Brush4.Size = new System.Drawing.Size(52, 50);
            this.Brush4.TabIndex = 3;
            this.Brush4.UseVisualStyleBackColor = true;
            this.Brush4.Click += new System.EventHandler(this.Brush3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(333, 48);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Brush2
            // 
            this.Brush2.BackgroundImage = global::FW1.Properties.Resources.Brush2;
            this.Brush2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brush2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brush2.Location = new System.Drawing.Point(80, 80);
            this.Brush2.Name = "Brush2";
            this.Brush2.Size = new System.Drawing.Size(50, 50);
            this.Brush2.TabIndex = 2;
            this.Brush2.UseVisualStyleBackColor = true;
            this.Brush2.Click += new System.EventHandler(this.Brush2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Create";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem.Text = "Open";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.referenceToolStripMenuItem.Text = "Reference";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutProgrammToolStripMenuItem.Text = "about programm";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(339, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 621);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "tbText";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Brush3;
        private System.Windows.Forms.Button Brush4;
        private System.Windows.Forms.Button Brush2;
        private System.Windows.Forms.Button Brush1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button Blue_Button;
        private System.Windows.Forms.Button Green_Button;
        private System.Windows.Forms.Button Red_Button;
        private System.Windows.Forms.Button Yellow_Button;
        private System.Windows.Forms.Button White_Button;
        private System.Windows.Forms.Button Black_Button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Eraser_Buttob;
        private System.Windows.Forms.Panel panel2;
    }
}

