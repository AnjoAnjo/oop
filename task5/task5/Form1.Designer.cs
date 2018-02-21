namespace task5
{
    partial class task5
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
            this.RL = new System.Windows.Forms.Button();
            this.LR = new System.Windows.Forms.Button();
            this.AllLR = new System.Windows.Forms.Button();
            this.AllRL = new System.Windows.Forms.Button();
            this.ListRight = new System.Windows.Forms.ListBox();
            this.ListLeft = new System.Windows.Forms.ListBox();
            this.RightCnt = new System.Windows.Forms.Label();
            this.LeftCnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RL
            // 
            this.RL.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.RL.Location = new System.Drawing.Point(172, 50);
            this.RL.Name = "RL";
            this.RL.Size = new System.Drawing.Size(40, 40);
            this.RL.TabIndex = 0;
            this.RL.Text = ">";
            this.RL.UseVisualStyleBackColor = true;
            this.RL.Click += new System.EventHandler(this.RL_Click);
            // 
            // LR
            // 
            this.LR.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.LR.Location = new System.Drawing.Point(172, 150);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(40, 40);
            this.LR.TabIndex = 1;
            this.LR.Text = "<";
            this.LR.UseVisualStyleBackColor = true;
            this.LR.Click += new System.EventHandler(this.LR_Click);
            // 
            // AllLR
            // 
            this.AllLR.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.AllLR.Location = new System.Drawing.Point(172, 350);
            this.AllLR.Name = "AllLR";
            this.AllLR.Size = new System.Drawing.Size(40, 40);
            this.AllLR.TabIndex = 2;
            this.AllLR.Text = "<<";
            this.AllLR.UseVisualStyleBackColor = true;
            this.AllLR.Click += new System.EventHandler(this.AllLR_Click);
            // 
            // AllRL
            // 
            this.AllRL.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.AllRL.Location = new System.Drawing.Point(172, 250);
            this.AllRL.Name = "AllRL";
            this.AllRL.Size = new System.Drawing.Size(40, 40);
            this.AllRL.TabIndex = 3;
            this.AllRL.Text = ">>";
            this.AllRL.UseVisualStyleBackColor = true;
            this.AllRL.Click += new System.EventHandler(this.AllRL_Click);
            // 
            // ListRight
            // 
            this.ListRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ListRight.FormattingEnabled = true;
            this.ListRight.ItemHeight = 24;
            this.ListRight.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "17",
            "06",
            "07",
            "08",
            "09",
            "10",
            "97"});
            this.ListRight.Location = new System.Drawing.Point(12, 50);
            this.ListRight.Name = "ListRight";
            this.ListRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListRight.Size = new System.Drawing.Size(145, 340);
            this.ListRight.TabIndex = 4;
            // 
            // ListLeft
            // 
            this.ListLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ListLeft.FormattingEnabled = true;
            this.ListLeft.ItemHeight = 24;
            this.ListLeft.Location = new System.Drawing.Point(227, 50);
            this.ListLeft.Name = "ListLeft";
            this.ListLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListLeft.Size = new System.Drawing.Size(145, 340);
            this.ListLeft.TabIndex = 5;
            // 
            // RightCnt
            // 
            this.RightCnt.AutoSize = true;
            this.RightCnt.BackColor = System.Drawing.Color.White;
            this.RightCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.RightCnt.Location = new System.Drawing.Point(9, 423);
            this.RightCnt.MaximumSize = new System.Drawing.Size(30, 30);
            this.RightCnt.MinimumSize = new System.Drawing.Size(30, 30);
            this.RightCnt.Name = "RightCnt";
            this.RightCnt.Size = new System.Drawing.Size(30, 30);
            this.RightCnt.TabIndex = 6;
            this.RightCnt.Text = "13";
            // 
            // LeftCnt
            // 
            this.LeftCnt.AutoSize = true;
            this.LeftCnt.BackColor = System.Drawing.Color.White;
            this.LeftCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LeftCnt.Location = new System.Drawing.Point(342, 423);
            this.LeftCnt.MaximumSize = new System.Drawing.Size(30, 30);
            this.LeftCnt.MinimumSize = new System.Drawing.Size(30, 30);
            this.LeftCnt.Name = "LeftCnt";
            this.LeftCnt.Size = new System.Drawing.Size(30, 30);
            this.LeftCnt.TabIndex = 7;
            this.LeftCnt.Text = "0";
            // 
            // task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.LeftCnt);
            this.Controls.Add(this.RightCnt);
            this.Controls.Add(this.ListLeft);
            this.Controls.Add(this.ListRight);
            this.Controls.Add(this.AllRL);
            this.Controls.Add(this.AllLR);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.RL);
            this.Name = "task5";
            this.Text = "task 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RL;
        private System.Windows.Forms.Button LR;
        private System.Windows.Forms.Button AllLR;
        private System.Windows.Forms.Button AllRL;
        private System.Windows.Forms.ListBox ListRight;
        private System.Windows.Forms.ListBox ListLeft;
        private System.Windows.Forms.Label RightCnt;
        private System.Windows.Forms.Label LeftCnt;
    }
}

