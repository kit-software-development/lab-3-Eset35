namespace Colorer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorB = new System.Windows.Forms.TrackBar();
            this.colorG = new System.Windows.Forms.TrackBar();
            this.colorR = new System.Windows.Forms.TrackBar();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(232, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 20);
            label1.TabIndex = 9;
            label1.Text = "Red:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.colorB);
            this.panel1.Controls.Add(this.colorG);
            this.panel1.Controls.Add(this.colorR);
            this.panel1.Controls.Add(this.ColorPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 268);
            this.panel1.TabIndex = 0;
            // 
            // colorB
            // 
            this.colorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorB.LargeChange = 1;
            this.colorB.Location = new System.Drawing.Point(296, 181);
            this.colorB.Maximum = 255;
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(182, 45);
            this.colorB.TabIndex = 8;
            this.colorB.TickFrequency = 15;
            this.colorB.Value = 125;
            this.colorB.ValueChanged += new System.EventHandler(this.BarChange);
            // 
            // colorG
            // 
            this.colorG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorG.LargeChange = 1;
            this.colorG.Location = new System.Drawing.Point(296, 103);
            this.colorG.Maximum = 255;
            this.colorG.Name = "colorG";
            this.colorG.Size = new System.Drawing.Size(182, 45);
            this.colorG.TabIndex = 7;
            this.colorG.TickFrequency = 15;
            this.colorG.Value = 125;
            this.colorG.ValueChanged += new System.EventHandler(this.BarChange);
            // 
            // colorR
            // 
            this.colorR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorR.LargeChange = 1;
            this.colorR.Location = new System.Drawing.Point(296, 24);
            this.colorR.Maximum = 255;
            this.colorR.Name = "colorR";
            this.colorR.Size = new System.Drawing.Size(182, 45);
            this.colorR.TabIndex = 6;
            this.colorR.TickFrequency = 15;
            this.colorR.Value = 125;
            this.colorR.ValueChanged += new System.EventHandler(this.BarChange);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(187, 268);
            this.ColorPanel.TabIndex = 5;
            this.ColorPanel.MouseEnter += new System.EventHandler(this.ShowHint);
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(232, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 20);
            label2.TabIndex = 10;
            label2.Text = "Green:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(232, 181);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Blue:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(292, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(18, 20);
            label4.TabIndex = 12;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(460, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 20);
            label5.TabIndex = 13;
            label5.Text = "255";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(460, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 20);
            label6.TabIndex = 15;
            label6.Text = "255";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(292, 142);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(18, 20);
            label7.TabIndex = 14;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.Location = new System.Drawing.Point(460, 219);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 20);
            label8.TabIndex = 17;
            label8.Text = "255";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(292, 219);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(18, 20);
            label9.TabIndex = 16;
            label9.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 268);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(535, 307);
            this.Name = "MainForm";
            this.Text = "Color Picker";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar colorB;
        private System.Windows.Forms.TrackBar colorG;
        private System.Windows.Forms.TrackBar colorR;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.ToolTip Hint;
    }
}

