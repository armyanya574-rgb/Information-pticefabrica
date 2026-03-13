namespace diplom
{
    partial class Form8
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
            this.nazporodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipnapravleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokVirachivaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUSSIAtwoDataSet6 = new diplom.RUSSIAtwoDataSet6();
            this.porodaTableAdapter = new diplom.RUSSIAtwoDataSet6TableAdapters.porodaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porodaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazporodiDataGridViewTextBoxColumn,
            this.tipnapravleniaDataGridViewTextBoxColumn,
            this.srokVirachivaniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.porodaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(628, 230);
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
            // nazporodiDataGridViewTextBoxColumn
            // 
            this.nazporodiDataGridViewTextBoxColumn.DataPropertyName = "Nazporodi";
            this.nazporodiDataGridViewTextBoxColumn.HeaderText = "Nazporodi";
            this.nazporodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazporodiDataGridViewTextBoxColumn.Name = "nazporodiDataGridViewTextBoxColumn";
            this.nazporodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipnapravleniaDataGridViewTextBoxColumn
            // 
            this.tipnapravleniaDataGridViewTextBoxColumn.DataPropertyName = "Tipnapravlenia";
            this.tipnapravleniaDataGridViewTextBoxColumn.HeaderText = "Tipnapravlenia";
            this.tipnapravleniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipnapravleniaDataGridViewTextBoxColumn.Name = "tipnapravleniaDataGridViewTextBoxColumn";
            this.tipnapravleniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // srokVirachivaniaDataGridViewTextBoxColumn
            // 
            this.srokVirachivaniaDataGridViewTextBoxColumn.DataPropertyName = "SrokVirachivania";
            this.srokVirachivaniaDataGridViewTextBoxColumn.HeaderText = "SrokVirachivania";
            this.srokVirachivaniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srokVirachivaniaDataGridViewTextBoxColumn.Name = "srokVirachivaniaDataGridViewTextBoxColumn";
            this.srokVirachivaniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // porodaBindingSource
            // 
            this.porodaBindingSource.DataMember = "poroda";
            this.porodaBindingSource.DataSource = this.rUSSIAtwoDataSet6;
            // 
            // rUSSIAtwoDataSet6
            // 
            this.rUSSIAtwoDataSet6.DataSetName = "RUSSIAtwoDataSet6";
            this.rUSSIAtwoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porodaTableAdapter
            // 
            this.porodaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(752, 361);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 22);
            this.textBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(752, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 79);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 80);
            this.button3.TabIndex = 6;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название породы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тмп направления (Мясное, яичное,оба)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Срок выращивания";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Мясное",
            "Яичное",
            "Мясно-яичное"});
            this.comboBox1.Location = new System.Drawing.Point(460, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources._55;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 762);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 616);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porodaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RUSSIAtwoDataSet6 rUSSIAtwoDataSet6;
        private System.Windows.Forms.BindingSource porodaBindingSource;
        private RUSSIAtwoDataSet6TableAdapters.porodaTableAdapter porodaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazporodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipnapravleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokVirachivaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}