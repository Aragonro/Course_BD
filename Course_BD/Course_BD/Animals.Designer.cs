namespace Course_BD
{
    partial class Animals
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_kinds = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(522, 221);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_kinds
            // 
            this.button_kinds.Location = new System.Drawing.Point(270, 245);
            this.button_kinds.Name = "button_kinds";
            this.button_kinds.Size = new System.Drawing.Size(118, 49);
            this.button_kinds.TabIndex = 2;
            this.button_kinds.Text = "Виды животных";
            this.button_kinds.UseVisualStyleBackColor = true;
            this.button_kinds.Click += new System.EventHandler(this.button_kinds_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 245);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(139, 49);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Добавить животного";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 358);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_kinds);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Animals";
            this.Text = "Animals";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_kinds;
        private System.Windows.Forms.Button button_add;
    }
}