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
    public partial class Form3 : Form
    {
        // Используем динамический путь, чтобы база всегда находилась
        string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\RUSSIAtwo.accdb";

        public Form3()
        {
            InitializeComponent();
            // Привязываем загрузку корзины при открытии формы
            this.Load += (s, e) => ОбновитьТаблицуКорзины();
        }

        private void ОбновитьТаблицуКорзины()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // Прямой запрос к файлу, чтобы сразу видеть добавленные товары
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM cart", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Принудительно выводим в таблицу на форме
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка отображения: " + ex.Message); }
        }

        // ГЛАВНАЯ КНОПКА КУПИТЬ (Списание со склада + Заказ)
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // 1. УМЕНЬШАЕМ ОСТАТКИ В ТАБЛИЦЕ SALES (Склад)
                    // Соединяем склад и корзину по названию товара и вычитаем купленное кол-во
                    string sqlUpdate = @"UPDATE sales 
                                       INNER JOIN cart ON sales.tovar = cart.tovar 
                                       SET sales.skolko = sales.skolko - cart.skolko";

                    using (OleDbCommand cmdUpdate = new OleDbCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // 2. ПЕРЕНОС ДАННЫХ В ТАБЛИЦУ ORDERS (История)
                    string sqlMove = "INSERT INTO orders (tovar, skolko, itogo, dataprod) " +
                                     "SELECT tovar, skolko, (skolko * pochem), Now() FROM cart";

                    using (OleDbCommand cmdMove = new OleDbCommand(sqlMove, conn))
                    {
                        cmdMove.ExecuteNonQuery();
                    }

                    // 3. ОЧИСТКА ТАБЛИЦЫ CART (Корзина)
                    using (OleDbCommand cmdClear = new OleDbCommand("DELETE FROM cart", conn))
                    {
                        cmdClear.ExecuteNonQuery();
                    }

                    MessageBox.Show("Покупка успешно оформлена!");
                    ОбновитьТаблицуКорзины();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при оформлении заказа: " + ex.Message);
            }
        }

        // КНОПКА УДАЛИТЬ ТОВАР ИЗ КОРЗИНЫ ПО ID (через textBox1)
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите ID из таблицы для удаления");
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    new OleDbCommand("DELETE FROM cart WHERE id = " + textBox1.Text, conn).ExecuteNonQuery();
                    ОбновитьТаблицуКорзины();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка удаления: " + ex.Message); }
        }

        // КНОПКИ ПЕРЕХОДА (названия оставлены как в твоем проекте)
        private void button2_Click_1(object sender, EventArgs e) { new Form9().Show(); this.Close(); }
        private void button6_Click_1(object sender, EventArgs e) { new Form6().Show(); this.Close(); }
        private void button4_Click_1(object sender, EventArgs e) { new Form1().Show(); this.Close(); }
    }
}