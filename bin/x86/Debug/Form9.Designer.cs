namespace diplom
{
    partial class Form9
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
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUSSIAtwoDataSet7 = new diplom.RUSSIAtwoDataSet7();
            this.salesTableAdapter = new diplom.RUSSIAtwoDataSet7TableAdapters.salesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(278, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(689, 252);
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
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.rUSSIAtwoDataSet7;
            // 
            // rUSSIAtwoDataSet7
            // 
            this.rUSSIAtwoDataSet7.DataSetName = "RUSSIAtwoDataSet7";
            this.rUSSIAtwoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 463);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить в корзину";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 570);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 98);
            this.button5.TabIndex = 9;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 475);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить в корзину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(967, 475);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 55);
            this.button4.TabIndex = 15;
            this.button4.Text = "Добавить в корзину";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(694, 570);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 98);
            this.button6.TabIndex = 16;
            this.button6.Text = "Перейти в корзину";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::diplom.Properties.Resources._44;
            this.pictureBox4.Location = new System.Drawing.Point(967, 285);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(174, 162);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::diplom.Properties.Resources._33;
            this.pictureBox3.Location = new System.Drawing.Point(694, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(174, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::diplom.Properties.Resources._22;
            this.pictureBox2.Location = new System.Drawing.Point(390, 285);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(109, 285);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::diplom.Properties.Resources._55;
            this.pictureBox5.Location = new System.Drawing.Point(-15, -35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1310, 777);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 722);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RUSSIAtwoDataSet7 rUSSIAtwoDataSet7;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private RUSSIAtwoDataSet7TableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolkoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pochemDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}