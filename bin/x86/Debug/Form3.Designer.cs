namespace diplom
{
    partial class Form3
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
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolkoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pochemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUSSIAtwoDataSet1 = new diplom.RUSSIAtwoDataSet1();
            this.cartTableAdapter = new diplom.RUSSIAtwoDataSet1TableAdapters.cartTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tovarDataGridViewTextBoxColumn,
            this.skolkoDataGridViewTextBoxColumn,
            this.pochemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(713, 338);
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
            // tovarDataGridViewTextBoxColumn
            // 
            this.tovarDataGridViewTextBoxColumn.DataPropertyName = "tovar";
            this.tovarDataGridViewTextBoxColumn.HeaderText = "tovar";
            this.tovarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tovarDataGridViewTextBoxColumn.Name = "tovarDataGridViewTextBoxColumn";
            this.tovarDataGridViewTextBoxColumn.Width = 125;
            // 
            // skolkoDataGridViewTextBoxColumn
            // 
            this.skolkoDataGridViewTextBoxColumn.DataPropertyName = "skolko";
            this.skolkoDataGridViewTextBoxColumn.HeaderText = "skolko";
            this.skolkoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skolkoDataGridViewTextBoxColumn.Name = "skolkoDataGridViewTextBoxColumn";
            this.skolkoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pochemDataGridViewTextBoxColumn
            // 
            this.pochemDataGridViewTextBoxColumn.DataPropertyName = "pochem";
            this.pochemDataGridViewTextBoxColumn.HeaderText = "pochem";
            this.pochemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pochemDataGridViewTextBoxColumn.Name = "pochemDataGridViewTextBoxColumn";
            this.pochemDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.rUSSIAtwoDataSet1;
            // 
            // rUSSIAtwoDataSet1
            // 
            this.rUSSIAtwoDataSet1.DataSetName = "RUSSIAtwoDataSet1";
            this.rUSSIAtwoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(946, 48);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(327, 86);
            this.button5.TabIndex = 7;
            this.button5.Text = "Удалить из корзины";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(529, 608);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 66);
            this.button4.TabIndex = 8;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(964, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 85);
            this.button2.TabIndex = 9;
            this.button2.Text = "Каталог товаров";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1004, 228);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 85);
            this.button1.TabIndex = 11;
            this.button1.Text = "Совершить покупку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(43, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(344, 88);
            this.button6.TabIndex = 12;
            this.button6.Text = "Перейти к истории покупок";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номер товара";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources._55;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1367, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RUSSIAtwoDataSet1 rUSSIAtwoDataSet1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private RUSSIAtwoDataSet1TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolkoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pochemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}