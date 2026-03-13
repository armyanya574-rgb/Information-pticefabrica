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
    public partial class Form2 : Form
    {
        // Путь к базе данных RUSSIAtwo.accdb (в папке bin/Debug)
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RUSSIAtwo.accdb";

        public Form2()
        {
            InitializeComponent();
        }

        // МЕТОД: ЗАПИСЬ В ТАБЛИЦУ SALES
        private void ДобавитьВБазу(string название, string количество, string цена)
        {
            if (string.IsNullOrWhiteSpace(количество) || string.IsNullOrWhiteSpace(цена))
            {
                MessageBox.Show("Заполни поля 'Сколько' и 'Почем' для товара: " + название);
                return;
            }

            try
            {
                using (OleDbConnection связь = new OleDbConnection(connectionString))
                {
                    связь.Open();
                    // ТЕПЕРЬ ПИШЕМ В ТАБЛИЦУ sales, чтобы клиент видел эти данные
                    string sql = "INSERT INTO sales (tovar, skolko, pochem) VALUES (?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(sql, связь);

                    cmd.Parameters.AddWithValue("?", название);
                    cmd.Parameters.AddWithValue("?", int.Parse(количество));
                    cmd.Parameters.AddWithValue("?", decimal.Parse(цена));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(название + " успешно добавлено в базу SALES!");

                    ОбновитьТаблицу();
                }
            }
            catch (Exception ош)
            {
                MessageBox.Show("Ошибка: " + ош.Message);
            }
        }

        // Кнопки добавления продуктов
        private void button1_Click(object sender, EventArgs e) { ДобавитьВБазу("Курица", textBox1.Text, textBox2.Text); }
        private void button2_Click(object sender, EventArgs e) { ДобавитьВБазу("Мясо", textBox3.Text, textBox4.Text); }
        private void button3_Click(object sender, EventArgs e) { ДобавитьВБазу("Крылышки", textBox5.Text, textBox6.Text); }
        private void button4_Click(object sender, EventArgs e) { ДобавитьВБазу("Яйца", textBox7.Text, textBox8.Text); }

        // МЕТОД: УДАЛЕНИЕ ИЗ ТАБЛИЦЫ SALES ПО ID
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Напиши ID в поле!");
                return;
            }

            try
            {
                using (OleDbConnection связь = new OleDbConnection(connectionString))
                {
                    связь.Open();
                    string номерДляУдаления = textBox9.Text;
                    // УДАЛЯЕМ ИЗ sales
                    string sql = "DELETE FROM sales WHERE id = " + номерДляУдаления;

                    OleDbCommand команда = new OleDbCommand(sql, связь);
                    int результат = команда.ExecuteNonQuery();

                    if (результат > 0)
                    {
                        MessageBox.Show("Товар удален из базы SALES!");
                        textBox9.Clear();
                        ОбновитьТаблицу();
                    }
                    else
                    {
                        MessageBox.Show("ID не найден в sales.");
                    }
                }
            }
            catch (Exception ош) { MessageBox.Show("Ошибка: " + ош.Message); }
        }

        // МЕТОД: ОБНОВЛЕНИЕ ЭКРАНА (БЕРЕМ ИЗ SALES)
        private void ОбновитьТаблицу()
        {
            try
            {
                using (OleDbConnection связь = new OleDbConnection(connectionString))
                {
                    связь.Open();
                    // Показываем админу то же самое, что увидит клиент
                    OleDbDataAdapter адаптер = new OleDbDataAdapter("SELECT * FROM sales", связь);
                    DataTable dt = new DataTable();
                    адаптер.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch { }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ОбновитьТаблицу();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.Show();


            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();

            f7.Show();


            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            { ДобавитьВБазу("Курица", textBox1.Text, textBox2.Text); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            { ДобавитьВБазу("Мясо", textBox3.Text, textBox4.Text); }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            { ДобавитьВБазу("Крылышки", textBox5.Text, textBox6.Text); }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            { ДобавитьВБазу("Яйца", textBox7.Text, textBox8.Text); }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.Show();


            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();

            f11.Show();


            this.Close();
        }
    }
}