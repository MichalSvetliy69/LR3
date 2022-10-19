namespace FW1
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoX = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(164, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(174, 22);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите свое имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoX
            // 
            this.LoX.Location = new System.Drawing.Point(22, 102);
            this.LoX.Name = "LoX";
            this.LoX.Size = new System.Drawing.Size(316, 35);
            this.LoX.TabIndex = 3;
            this.LoX.Text = "Hello";
            this.LoX.UseVisualStyleBackColor = true;
            this.LoX.Click += new System.EventHandler(this.LoX_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(316, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 233);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.LoX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "tbText";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoX;
        private System.Windows.Forms.Button btnExit;
    }
}

