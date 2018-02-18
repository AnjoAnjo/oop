namespace task3
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
            this.Out = new System.Windows.Forms.Label();
            this.In = new System.Windows.Forms.TextBox();
            this.GenStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Out.Location = new System.Drawing.Point(75, 164);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(37, 29);
            this.Out.TabIndex = 1;
            this.Out.Text = "    ";
            // 
            // In
            // 
            this.In.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.In.Location = new System.Drawing.Point(56, 55);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(284, 27);
            this.In.TabIndex = 2;
            this.In.TextChanged += new System.EventHandler(this.In_TextChanged);
            // 
            // GenStr
            // 
            this.GenStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenStr.Location = new System.Drawing.Point(412, 55);
            this.GenStr.Name = "GenStr";
            this.GenStr.Size = new System.Drawing.Size(205, 26);
            this.GenStr.TabIndex = 3;
            this.GenStr.Text = "Generate string";
            this.GenStr.UseVisualStyleBackColor = true;
            this.GenStr.Click += new System.EventHandler(this.GenStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.GenStr);
            this.Controls.Add(this.In);
            this.Controls.Add(this.Out);
            this.Name = "Form1";
            this.Text = "Task 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Out;
        private System.Windows.Forms.TextBox In;
        private System.Windows.Forms.Button GenStr;
    }
}

