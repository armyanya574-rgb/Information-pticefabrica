namespace diplom
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vmestimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otvetstvenniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chehaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUSSIAtwoDataSet2 = new diplom.RUSSIAtwoDataSet2();
            this.chehaTableAdapter = new diplom.RUSSIAtwoDataSet2TableAdapters.chehaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chehaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.vmestimostDataGridViewTextBoxColumn,
            this.otvetstvenniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chehaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(667, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.Width = 125;
            // 
            // vmestimostDataGridViewTextBoxColumn
            // 
            this.vmestimostDataGridViewTextBoxColumn.DataPropertyName = "Vmestimost";
            this.vmestimostDataGridViewTextBoxColumn.HeaderText = "Vmestimost";
            this.vmestimostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vmestimostDataGridViewTextBoxColumn.Name = "vmestimostDataGridViewTextBoxColumn";
            this.vmestimostDataGridViewTextBoxColumn.Width = 125;
            // 
            // otvetstvenniDataGridViewTextBoxColumn
            // 
            this.otvetstvenniDataGridViewTextBoxColumn.DataPropertyName = "Otvetstvenni";
            this.otvetstvenniDataGridViewTextBoxColumn.HeaderText = "Otvetstvenni";
            this.otvetstvenniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otvetstvenniDataGridViewTextBoxColumn.Name = "otvetstvenniDataGridViewTextBoxColumn";
            this.otvetstvenniDataGridViewTextBoxColumn.Width = 125;
            // 
            // chehaBindingSource
            // 
            this.chehaBindingSource.DataMember = "cheha";
            this.chehaBindingSource.DataSource = this.rUSSIAtwoDataSet2;
            // 
            // rUSSIAtwoDataSet2
            // 
            this.rUSSIAtwoDataSet2.DataSetName = "RUSSIAtwoDataSet2";
            this.rUSSIAtwoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chehaTableAdapter
            // 
            this.chehaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 414);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(934, 459);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(824, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 22);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название Цеха";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вметимость птицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ответственный управляющий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поиск по названию цеха";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 78);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 80);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить выбранное";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(769, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 86);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 537);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 100);
            this.button4.TabIndex = 12;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources._55;
            this.pictureBox1.Location = new System.Drawing.Point(-30, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 762);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chehaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RUSSIAtwoDataSet2 rUSSIAtwoDataSet2;
        private System.Windows.Forms.BindingSource chehaBindingSource;
        private RUSSIAtwoDataSet2TableAdapters.chehaTableAdapter chehaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vmestimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otvetstvenniDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}