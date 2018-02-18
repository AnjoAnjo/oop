namespace WindowsFormsApp1
{
    partial class task1
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
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.previous.Location = new System.Drawing.Point(20, 200);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(90, 30);
            this.previous.TabIndex = 0;
            this.previous.Text = "Предыдущее";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.next.Location = new System.Drawing.Point(170, 200);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(90, 30);
            this.next.TabIndex = 1;
            this.next.Text = "Следующее";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.OldLace;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(125, 80);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(29, 31);
            this.number.TabIndex = 2;
            this.number.Text = "0";
            // 
            // task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.number);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Name = "task1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label number;
    }
}

