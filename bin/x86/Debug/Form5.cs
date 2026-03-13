using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form5 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RUSSIAtwo.accdb";

        public Form5()
        {
            InitializeComponent();
            // Привязываем загрузку таблицы
            this.Load += (s, e) => ОбновитьЖурнал();
        }

        private void ОбновитьЖурнал()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM jurnal ORDER BY id DESC", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); }
        }

        // КНОПКА "ВНЕСТИ ЗАПИСЬ" (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO jurnal (partii, datazamera, rashodkormakg, srednivesgr, padejgolov) " +
                                 "VALUES (?, ?, ?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    // Передаем параметры в строгом порядке
                    cmd.Parameters.AddWithValue("?", int.Parse(textBox1.Text)); // partii
                    cmd.Parameters.AddWithValue("?", dateTimePicker1.Value.Date); // datazamera
                    cmd.Parameters.AddWithValue("?", int.Parse(textBox2.Text)); // rashodkormakg
                    cmd.Parameters.AddWithValue("?", int.Parse(textBox3.Text)); // srednivesgr
                    cmd.Parameters.AddWithValue("?", int.Parse(textBox4.Text)); // padejgolov

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные замера сохранены!");

                    // Очистка и обновление
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    ОбновитьЖурнал();
                }
            }
            catch (Exception ex) { MessageBox.Show("Заполните все поля числами! Ошибка: " + ex.Message); }
        }

        // КНОПКА "УДАЛИТЬ" (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    new OleDbCommand("DELETE FROM jurnal WHERE id = " + id, conn).ExecuteNonQuery();
                    ОбновитьЖурнал();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // КНОПКА "НАЗАД" (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            new Form11().Show(); // Или какая у тебя главная
            this.Close();
        }
    }
}