namespace Course_BD
{
    partial class Cells
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.textBox_Kind = new System.Windows.Forms.TextBox();
            this.button_change = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_return = new System.Windows.Forms.Button();
            this.comboBox_filtr = new System.Windows.Forms.ComboBox();
            this.textBox_filtr = new System.Windows.Forms.TextBox();
            this.button_filtr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер клетки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площадь клетки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип клетки";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(519, 43);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_S
            // 
            this.textBox_S.Location = new System.Drawing.Point(519, 73);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(100, 20);
            this.textBox_S.TabIndex = 6;
            // 
            // textBox_Kind
            // 
            this.textBox_Kind.Location = new System.Drawing.Point(519, 100);
            this.textBox_Kind.Name = "textBox_Kind";
            this.textBox_Kind.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kind.TabIndex = 7;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(519, 143);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(98, 23);
            this.button_change.TabIndex = 8;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 231);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(117, 44);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Добавить клетку";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(135, 231);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(117, 44);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить клетку";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 366);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(287, 366);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(195, 150);
            this.dataGridView3.TabIndex = 12;
            // 
            // comboBox_search
            // 
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Items.AddRange(new object[] {
            "Номер клетки",
            "Площадь клетки",
            "Вид клетки",
            "Количество животных в клетке"});
            this.comboBox_search.Location = new System.Drawing.Point(287, 244);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(98, 21);
            this.comboBox_search.TabIndex = 13;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(287, 302);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(98, 23);
            this.button_search.TabIndex = 14;
            this.button_search.Text = "Фильтрация";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(287, 276);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_search.TabIndex = 15;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(346, 331);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 16;
            this.button_return.Text = "Вернуть";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // comboBox_filtr
            // 
            this.comboBox_filtr.FormattingEnabled = true;
            this.comboBox_filtr.Items.AddRange(new object[] {
            "Номер клетки",
            "Площадь клетки",
            "Вид клетки",
            "Количество животных в клетке"});
            this.comboBox_filtr.Location = new System.Drawing.Point(398, 244);
            this.comboBox_filtr.Name = "comboBox_filtr";
            this.comboBox_filtr.Size = new System.Drawing.Size(84, 21);
            this.comboBox_filtr.TabIndex = 17;
            // 
            // textBox_filtr
            // 
            this.textBox_filtr.Location = new System.Drawing.Point(398, 276);
            this.textBox_filtr.Name = "textBox_filtr";
            this.textBox_filtr.Size = new System.Drawing.Size(84, 20);
            this.textBox_filtr.TabIndex = 18;
            // 
            // button_filtr
            // 
            this.button_filtr.Location = new System.Drawing.Point(398, 302);
            this.button_filtr.Name = "button_filtr";
            this.button_filtr.Size = new System.Drawing.Size(84, 23);
            this.button_filtr.TabIndex = 19;
            this.button_filtr.Text = "Поиск";
            this.button_filtr.UseVisualStyleBackColor = true;
            this.button_filtr.Click += new System.EventHandler(this.button_filtr_Click);
            // 
            // Cells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 562);
            this.Controls.Add(this.button_filtr);
            this.Controls.Add(this.textBox_filtr);
            this.Controls.Add(this.comboBox_filtr);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_search);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_Kind);
            this.Controls.Add(this.textBox_S);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cells";
            this.Text = "Cells";
            this.Activated += new System.EventHandler(this.Cells_Activated);
            this.Load += new System.EventHandler(this.Cells_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cells_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.TextBox textBox_Kind;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.ComboBox comboBox_filtr;
        private System.Windows.Forms.TextBox textBox_filtr;
        private System.Windows.Forms.Button button_filtr;
    }
}