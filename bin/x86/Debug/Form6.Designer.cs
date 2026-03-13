namespace diplom
{
    partial class Form6
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
            this.itogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUSSIAtwoDataSet4 = new diplom.RUSSIAtwoDataSet4();
            this.ordersTableAdapter = new diplom.RUSSIAtwoDataSet4TableAdapters.ordersTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet4)).BeginInit();
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
            this.itogoDataGridViewTextBoxColumn,
            this.dataprodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(221, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(755, 347);
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
            // itogoDataGridViewTextBoxColumn
            // 
            this.itogoDataGridViewTextBoxColumn.DataPropertyName = "itogo";
            this.itogoDataGridViewTextBoxColumn.HeaderText = "itogo";
            this.itogoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itogoDataGridViewTextBoxColumn.Name = "itogoDataGridViewTextBoxColumn";
            this.itogoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataprodDataGridViewTextBoxColumn
            // 
            this.dataprodDataGridViewTextBoxColumn.DataPropertyName = "dataprod";
            this.dataprodDataGridViewTextBoxColumn.HeaderText = "dataprod";
            this.dataprodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataprodDataGridViewTextBoxColumn.Name = "dataprodDataGridViewTextBoxColumn";
            this.dataprodDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.rUSSIAtwoDataSet4;
            // 
            // rUSSIAtwoDataSet4
            // 
            this.rUSSIAtwoDataSet4.DataSetName = "RUSSIAtwoDataSet4";
            this.rUSSIAtwoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(353, 80);
            this.button4.TabIndex = 5;
            this.button4.Text = "Назад к покупкам!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ваша история покупок. Продолжим?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources._55;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 762);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RUSSIAtwoDataSet4 rUSSIAtwoDataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RUSSIAtwoDataSet4TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolkoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}