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
    public partial class Form9 : Form
    {
        // Динамический путь к базе данных (всегда ищет в папке с программой)
        string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\RUSSIAtwo.accdb";

        public Form9()
        {
            InitializeComponent();
            // Привязываем загрузку витрины
            this.Load += (s, e) => ПоказатьВитрину();
        }

        private void ПоказатьВитрину()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM sales", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка витрины: " + ex.Message); }
        }

        private void ДобавитьВКорзину(string название)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // 1. Узнаем цену из sales
                    OleDbCommand cmdCheck = new OleDbCommand("SELECT pochem FROM sales WHERE tovar = @n", conn);
                    cmdCheck.Parameters.AddWithValue("@n", название);
                    object price = cmdCheck.ExecuteScalar();

                    if (price != null)
                    {
                        // 2. Добавляем 5 штук в cart (строгий порядок: tovar, skolko, pochem)
                        OleDbCommand cmdAdd = new OleDbCommand("INSERT INTO cart (tovar, skolko, pochem) VALUES (?, ?, ?)", conn);
                        cmdAdd.Parameters.AddWithValue("?", название);
                        cmdAdd.Parameters.AddWithValue("?", 5); // СРАЗУ ПО 5 ШТУК
                        cmdAdd.Parameters.AddWithValue("?", Convert.ToDecimal(price));

                        cmdAdd.ExecuteNonQuery();
                        MessageBox.Show(название + " (5 шт.) добавлено в корзину!");
                    }
                    else { MessageBox.Show("Товар не найден в базе!"); }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); }
        }

        // Твои кнопки (названия оставлены без изменений)
        private void button1_Click_1(object sender, EventArgs e) => ДобавитьВКорзину("Курица");
        private void button2_Click_1(object sender, EventArgs e) => ДобавитьВКорзину("Мясо");
        private void button3_Click_1(object sender, EventArgs e) => ДобавитьВКорзину("Крылышки");
        private void button4_Click_1(object sender, EventArgs e) => ДобавитьВКорзину("Яйца");

        private void button5_Click(object sender, EventArgs e) { new Form1().Show(); this.Close(); }
        private void button6_Click(object sender, EventArgs e) { new Form3().Show(); this.Close(); }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Form3().Show(); // Замени на нужную форму возврата
            this.Close();
        }
    }
}