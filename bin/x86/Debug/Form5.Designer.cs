namespace diplom
{
    partial class Form5
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
            this.partiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rashodkormakgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednivesgrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padejgolovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurnalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUSSIAtwoDataSet3 = new diplom.RUSSIAtwoDataSet3();
            this.jurnalTableAdapter = new diplom.RUSSIAtwoDataSet3TableAdapters.jurnalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.partiiDataGridViewTextBoxColumn,
            this.datazameraDataGridViewTextBoxColumn,
            this.rashodkormakgDataGridViewTextBoxColumn,
            this.srednivesgrDataGridViewTextBoxColumn,
            this.padejgolovDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jurnalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(811, 279);
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
            // partiiDataGridViewTextBoxColumn
            // 
            this.partiiDataGridViewTextBoxColumn.DataPropertyName = "partii";
            this.partiiDataGridViewTextBoxColumn.HeaderText = "partii";
            this.partiiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partiiDataGridViewTextBoxColumn.Name = "partiiDataGridViewTextBoxColumn";
            this.partiiDataGridViewTextBoxColumn.Width = 125;
            // 
            // datazameraDataGridViewTextBoxColumn
            // 
            this.datazameraDataGridViewTextBoxColumn.DataPropertyName = "datazamera";
            this.datazameraDataGridViewTextBoxColumn.HeaderText = "datazamera";
            this.datazameraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datazameraDataGridViewTextBoxColumn.Name = "datazameraDataGridViewTextBoxColumn";
            this.datazameraDataGridViewTextBoxColumn.Width = 125;
            // 
            // rashodkormakgDataGridViewTextBoxColumn
            // 
            this.rashodkormakgDataGridViewTextBoxColumn.DataPropertyName = "rashodkormakg";
            this.rashodkormakgDataGridViewTextBoxColumn.HeaderText = "rashodkormakg";
            this.rashodkormakgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rashodkormakgDataGridViewTextBoxColumn.Name = "rashodkormakgDataGridViewTextBoxColumn";
            this.rashodkormakgDataGridViewTextBoxColumn.Width = 125;
            // 
            // srednivesgrDataGridViewTextBoxColumn
            // 
            this.srednivesgrDataGridViewTextBoxColumn.DataPropertyName = "srednivesgr";
            this.srednivesgrDataGridViewTextBoxColumn.HeaderText = "srednivesgr";
            this.srednivesgrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srednivesgrDataGridViewTextBoxColumn.Name = "srednivesgrDataGridViewTextBoxColumn";
            this.srednivesgrDataGridViewTextBoxColumn.Width = 125;
            // 
            // padejgolovDataGridViewTextBoxColumn
            // 
            this.padejgolovDataGridViewTextBoxColumn.DataPropertyName = "padejgolov";
            this.padejgolovDataGridViewTextBoxColumn.HeaderText = "padejgolov";
            this.padejgolovDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.padejgolovDataGridViewTextBoxColumn.Name = "padejgolovDataGridViewTextBoxColumn";
            this.padejgolovDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurnalBindingSource
            // 
            this.jurnalBindingSource.DataMember = "jurnal";
            this.jurnalBindingSource.DataSource = this.rUSSIAtwoDataSet3;
            // 
            // rUSSIAtwoDataSet3
            // 
            this.rUSSIAtwoDataSet3.DataSetName = "RUSSIAtwoDataSet3";
            this.rUSSIAtwoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jurnalTableAdapter
            // 
            this.jurnalTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер партии";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 497);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата замера";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Расход корма (кг)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 356);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Средний вес (гр)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(597, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(930, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Падеж (голов)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(869, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 22);
            this.textBox4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 83);
            this.button1.TabIndex = 11;
            this.button1.Text = "Внести запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 83);
            this.button2.TabIndex = 12;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 92);
            this.button3.TabIndex = 13;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources._55;
            this.pictureBox1.Location = new System.Drawing.Point(0, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 762);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 678);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUSSIAtwoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RUSSIAtwoDataSet3 rUSSIAtwoDataSet3;
        private System.Windows.Forms.BindingSource jurnalBindingSource;
        private RUSSIAtwoDataSet3TableAdapters.jurnalTableAdapter jurnalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rashodkormakgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednivesgrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padejgolovDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}