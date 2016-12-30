namespace Course_BD
{
    partial class Kinds
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
            this.comboBox_kinds = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.button_add_kind = new System.Windows.Forms.Button();
            this.button_add_cell = new System.Windows.Forms.Button();
            this.button_del_k = new System.Windows.Forms.Button();
            this.button_del_c = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.textBox_add_kind = new System.Windows.Forms.ComboBox();
            this.textBox_add_cell = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_kinds
            // 
            this.comboBox_kinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kinds.FormattingEnabled = true;
            this.comboBox_kinds.Location = new System.Drawing.Point(83, 12);
            this.comboBox_kinds.Name = "comboBox_kinds";
            this.comboBox_kinds.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kinds.TabIndex = 0;
            this.comboBox_kinds.SelectedIndexChanged += new System.EventHandler(this.comboBox_kinds_SelectedIndexChanged);
            this.comboBox_kinds.TextChanged += new System.EventHandler(this.comboBox_kinds_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(133, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(151, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(132, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(178, 347);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(105, 51);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Добавить новый вид";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(12, 363);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(133, 20);
            this.textBox_add.TabIndex = 4;
            // 
            // button_add_kind
            // 
            this.button_add_kind.Location = new System.Drawing.Point(12, 279);
            this.button_add_kind.Name = "button_add_kind";
            this.button_add_kind.Size = new System.Drawing.Size(133, 61);
            this.button_add_kind.TabIndex = 5;
            this.button_add_kind.Text = "Добавить дружелюбный вид";
            this.button_add_kind.UseVisualStyleBackColor = true;
            this.button_add_kind.Click += new System.EventHandler(this.button_add_kind_Click);
            // 
            // button_add_cell
            // 
            this.button_add_cell.Location = new System.Drawing.Point(151, 280);
            this.button_add_cell.Name = "button_add_cell";
            this.button_add_cell.Size = new System.Drawing.Size(132, 61);
            this.button_add_cell.TabIndex = 6;
            this.button_add_cell.Text = "Добавить вид подходящей клетки";
            this.button_add_cell.UseVisualStyleBackColor = true;
            this.button_add_cell.Click += new System.EventHandler(this.button_add_cell_Click);
            // 
            // button_del_k
            // 
            this.button_del_k.Location = new System.Drawing.Point(13, 205);
            this.button_del_k.Name = "button_del_k";
            this.button_del_k.Size = new System.Drawing.Size(132, 39);
            this.button_del_k.TabIndex = 9;
            this.button_del_k.Text = "Удалить дружелюбный вид";
            this.button_del_k.UseVisualStyleBackColor = true;
            this.button_del_k.Click += new System.EventHandler(this.button_del_k_Click);
            // 
            // button_del_c
            // 
            this.button_del_c.Location = new System.Drawing.Point(151, 205);
            this.button_del_c.Name = "button_del_c";
            this.button_del_c.Size = new System.Drawing.Size(132, 42);
            this.button_del_c.TabIndex = 10;
            this.button_del_c.Text = "Удалить клетку";
            this.button_del_c.UseVisualStyleBackColor = true;
            this.button_del_c.Click += new System.EventHandler(this.button_del_c_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(107, 404);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(97, 41);
            this.button_del.TabIndex = 11;
            this.button_del.Text = "Удалить вид";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // textBox_add_kind
            // 
            this.textBox_add_kind.FormattingEnabled = true;
            this.textBox_add_kind.Location = new System.Drawing.Point(13, 253);
            this.textBox_add_kind.Name = "textBox_add_kind";
            this.textBox_add_kind.Size = new System.Drawing.Size(132, 21);
            this.textBox_add_kind.TabIndex = 7;
            // 
            // textBox_add_cell
            // 
            this.textBox_add_cell.FormattingEnabled = true;
            this.textBox_add_cell.Location = new System.Drawing.Point(151, 253);
            this.textBox_add_cell.Name = "textBox_add_cell";
            this.textBox_add_cell.Size = new System.Drawing.Size(132, 21);
            this.textBox_add_cell.TabIndex = 8;
            // 
            // Kinds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 466);
            this.Controls.Add(this.textBox_add_cell);
            this.Controls.Add(this.textBox_add_kind);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_del_c);
            this.Controls.Add(this.button_del_k);
            this.Controls.Add(this.button_add_cell);
            this.Controls.Add(this.button_add_kind);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_kinds);
            this.Name = "Kinds";
            this.ShowInTaskbar = false;
            this.Text = "Виды";
            this.Load += new System.EventHandler(this.Kinds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_kinds;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.Button button_add_kind;
        private System.Windows.Forms.Button button_add_cell;
        private System.Windows.Forms.Button button_del_k;
        private System.Windows.Forms.Button button_del_c;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.ComboBox textBox_add_kind;
        private System.Windows.Forms.ComboBox textBox_add_cell;
    }
}