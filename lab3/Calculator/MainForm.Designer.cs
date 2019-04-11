namespace Calculator
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
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_7
            // 
            this.button_7.AutoSize = true;
            this.button_7.Location = new System.Drawing.Point(10, 98);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(63, 47);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.NumClick);
            // 
            // button_8
            // 
            this.button_8.AutoSize = true;
            this.button_8.Location = new System.Drawing.Point(79, 98);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(63, 47);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.NumClick);
            // 
            // button_9
            // 
            this.button_9.AutoSize = true;
            this.button_9.Location = new System.Drawing.Point(148, 98);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(63, 47);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.NumClick);
            // 
            // button_plus
            // 
            this.button_plus.AutoSize = true;
            this.button_plus.Location = new System.Drawing.Point(217, 98);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(63, 47);
            this.button_plus.TabIndex = 3;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.OpClick);
            // 
            // button_min
            // 
            this.button_min.AutoSize = true;
            this.button_min.Location = new System.Drawing.Point(217, 165);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(63, 47);
            this.button_min.TabIndex = 7;
            this.button_min.Text = "-";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.OpClick);
            // 
            // button_6
            // 
            this.button_6.AutoSize = true;
            this.button_6.Location = new System.Drawing.Point(148, 165);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(63, 47);
            this.button_6.TabIndex = 6;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.NumClick);
            // 
            // button_5
            // 
            this.button_5.AutoSize = true;
            this.button_5.Location = new System.Drawing.Point(79, 165);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(63, 47);
            this.button_5.TabIndex = 5;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.NumClick);
            // 
            // button_4
            // 
            this.button_4.AutoSize = true;
            this.button_4.Location = new System.Drawing.Point(10, 165);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(63, 47);
            this.button_4.TabIndex = 4;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.NumClick);
            // 
            // button_mult
            // 
            this.button_mult.AutoSize = true;
            this.button_mult.Location = new System.Drawing.Point(217, 234);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(63, 47);
            this.button_mult.TabIndex = 11;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.OpClick);
            // 
            // button_3
            // 
            this.button_3.AutoSize = true;
            this.button_3.Location = new System.Drawing.Point(148, 234);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(63, 47);
            this.button_3.TabIndex = 10;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.NumClick);
            // 
            // button_2
            // 
            this.button_2.AutoSize = true;
            this.button_2.Location = new System.Drawing.Point(79, 234);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(63, 47);
            this.button_2.TabIndex = 9;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.NumClick);
            // 
            // button_1
            // 
            this.button_1.AutoSize = true;
            this.button_1.Location = new System.Drawing.Point(10, 234);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(63, 47);
            this.button_1.TabIndex = 8;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.NumClick);
            // 
            // button_div
            // 
            this.button_div.AutoSize = true;
            this.button_div.Location = new System.Drawing.Point(217, 306);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(63, 47);
            this.button_div.TabIndex = 15;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.OpClick);
            // 
            // button_point
            // 
            this.button_point.AutoSize = true;
            this.button_point.Location = new System.Drawing.Point(148, 306);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(63, 47);
            this.button_point.TabIndex = 14;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.SetPoint);
            // 
            // button_0
            // 
            this.button_0.AutoSize = true;
            this.button_0.Location = new System.Drawing.Point(79, 306);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(63, 47);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.NumClick);
            // 
            // button_ce
            // 
            this.button_ce.AutoSize = true;
            this.button_ce.Location = new System.Drawing.Point(10, 306);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(63, 47);
            this.button_ce.TabIndex = 12;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            // 
            // button_res
            // 
            this.button_res.Location = new System.Drawing.Point(10, 368);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(264, 70);
            this.button_res.TabIndex = 16;
            this.button_res.Text = "=";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.ResClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 77);
            this.label1.TabIndex = 17;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_point);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.MaximumSize = new System.Drawing.Size(304, 489);
            this.MinimumSize = new System.Drawing.Size(304, 489);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Label label1;
    }
}

