namespace task4
{
    partial class Task4
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
            this.Find = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.TextBox();
            this.Out = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Find.Location = new System.Drawing.Point(223, 59);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(150, 38);
            this.Find.TabIndex = 0;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // In
            // 
            this.In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.In.Location = new System.Drawing.Point(27, 59);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(170, 30);
            this.In.TabIndex = 1;
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.BackColor = System.Drawing.Color.MistyRose;
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Out.Location = new System.Drawing.Point(220, 133);
            this.Out.MaximumSize = new System.Drawing.Size(175, 379);
            this.Out.MinimumSize = new System.Drawing.Size(175, 379);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(175, 379);
            this.Out.TabIndex = 3;
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.MistyRose;
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List.ForeColor = System.Drawing.Color.Black;
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 25;
            this.List.Items.AddRange(new object[] {
            "Apple",
            "Assembler",
            "Hell",
            "EnamoredToad",
            "Wrists",
            "Ginger",
            "Cinnamon",
            "Fox",
            "LittleFox",
            "Meow",
            "Cat",
            "Coffee",
            "Milk",
            "Snort",
            "Cocoa"});
            this.List.Location = new System.Drawing.Point(27, 133);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(170, 379);
            this.List.TabIndex = 4;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(439, 532);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.In);
            this.Controls.Add(this.Find);
            this.Name = "Task4";
            this.Text = "Task 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox In;
        private System.Windows.Forms.Label Out;
        private System.Windows.Forms.ListBox List;
    }
}

