namespace Course_BD
{
    partial class Gabela
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
            this.button_f_otchet = new System.Windows.Forms.Button();
            this.textBox_month = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.Мк = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_f_otchet
            // 
            this.button_f_otchet.Location = new System.Drawing.Point(125, 71);
            this.button_f_otchet.Name = "button_f_otchet";
            this.button_f_otchet.Size = new System.Drawing.Size(87, 23);
            this.button_f_otchet.TabIndex = 1;
            this.button_f_otchet.Text = "Отчёт";
            this.button_f_otchet.UseVisualStyleBackColor = true;
            this.button_f_otchet.Click += new System.EventHandler(this.button_f_otchet_Click);
            // 
            // textBox_month
            // 
            this.textBox_month.Location = new System.Drawing.Point(125, 45);
            this.textBox_month.Name = "textBox_month";
            this.textBox_month.Size = new System.Drawing.Size(41, 20);
            this.textBox_month.TabIndex = 2;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(175, 45);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(37, 20);
            this.textBox_year.TabIndex = 3;
            // 
            // Мк
            // 
            this.Мк.AutoSize = true;
            this.Мк.Location = new System.Drawing.Point(122, 19);
            this.Мк.Name = "Мк";
            this.Мк.Size = new System.Drawing.Size(40, 13);
            this.Мк.TabIndex = 4;
            this.Мк.Text = "Месяц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Год";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Виды животных в зоопарке";
            // 
            // Gabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Мк);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_month);
            this.Controls.Add(this.button_f_otchet);
            this.Name = "Gabela";
            this.Text = "Отчёты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_f_otchet;
        private System.Windows.Forms.TextBox textBox_month;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label Мк;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}