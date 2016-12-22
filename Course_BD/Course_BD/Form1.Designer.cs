namespace Course_BD
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_animals = new System.Windows.Forms.Button();
            this.button_wards = new System.Windows.Forms.Button();
            this.button_cells = new System.Windows.Forms.Button();
            this.button_statik = new System.Windows.Forms.Button();
            this.button_gabela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_animals
            // 
            this.button_animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_animals.ForeColor = System.Drawing.Color.Beige;
            this.button_animals.Image = ((System.Drawing.Image)(resources.GetObject("button_animals.Image")));
            this.button_animals.Location = new System.Drawing.Point(12, 101);
            this.button_animals.Name = "button_animals";
            this.button_animals.Size = new System.Drawing.Size(169, 100);
            this.button_animals.TabIndex = 0;
            this.button_animals.Text = "Животные";
            this.button_animals.UseVisualStyleBackColor = true;
            this.button_animals.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_wards
            // 
            this.button_wards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_wards.ForeColor = System.Drawing.Color.Beige;
            this.button_wards.Image = ((System.Drawing.Image)(resources.GetObject("button_wards.Image")));
            this.button_wards.Location = new System.Drawing.Point(187, 101);
            this.button_wards.Name = "button_wards";
            this.button_wards.Size = new System.Drawing.Size(169, 100);
            this.button_wards.TabIndex = 1;
            this.button_wards.Text = "Работники";
            this.button_wards.UseVisualStyleBackColor = true;
            this.button_wards.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_cells
            // 
            this.button_cells.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cells.ForeColor = System.Drawing.Color.Beige;
            this.button_cells.Image = ((System.Drawing.Image)(resources.GetObject("button_cells.Image")));
            this.button_cells.Location = new System.Drawing.Point(101, 207);
            this.button_cells.Name = "button_cells";
            this.button_cells.Size = new System.Drawing.Size(169, 100);
            this.button_cells.TabIndex = 2;
            this.button_cells.Text = "Клетки";
            this.button_cells.UseVisualStyleBackColor = true;
            this.button_cells.Click += new System.EventHandler(this.button_cells_Click);
            // 
            // button_statik
            // 
            this.button_statik.Location = new System.Drawing.Point(12, 12);
            this.button_statik.Name = "button_statik";
            this.button_statik.Size = new System.Drawing.Size(75, 23);
            this.button_statik.TabIndex = 3;
            this.button_statik.Text = "Статистика";
            this.button_statik.UseVisualStyleBackColor = true;
            this.button_statik.Click += new System.EventHandler(this.button_statik_Click);
            // 
            // button_gabela
            // 
            this.button_gabela.Location = new System.Drawing.Point(281, 12);
            this.button_gabela.Name = "button_gabela";
            this.button_gabela.Size = new System.Drawing.Size(75, 23);
            this.button_gabela.TabIndex = 4;
            this.button_gabela.Text = "Отчёты";
            this.button_gabela.UseVisualStyleBackColor = true;
            this.button_gabela.Click += new System.EventHandler(this.button_gabela_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 322);
            this.Controls.Add(this.button_gabela);
            this.Controls.Add(this.button_statik);
            this.Controls.Add(this.button_cells);
            this.Controls.Add(this.button_wards);
            this.Controls.Add(this.button_animals);
            this.Name = "Main";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_animals;
        private System.Windows.Forms.Button button_wards;
        private System.Windows.Forms.Button button_cells;
        private System.Windows.Forms.Button button_statik;
        private System.Windows.Forms.Button button_gabela;
    }
}

