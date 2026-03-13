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
    public partial class Form7 : Form
    {
        // Динамический путь к базе в папке Debug
        string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\RUSSIAtwo.accdb";

        public Form7()
        {
            InitializeComponent();
            // Загружаем данные при открытии 7-й формы
            this.Load += (s, e) => ОбновитьТаблицуПартий();
        }

        private void ОбновитьТаблицуПартий()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // Сортируем по дате посадки (свежие сверху)
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM partii ORDER BY dataposadki DESC", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка загрузки партий: " + ex.Message); }
        }

        // КНОПКА ДОБАВИТЬ (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Заполните количество и статус!");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // Используем [status] в скобках, так как это зарезервированное слово в SQL
                    string sql = "INSERT INTO partii (dataposadki, tekycheekolvo, [status]) VALUES (?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("?", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("?", int.Parse(textBox1.Text)); // Количество
                    cmd.Parameters.AddWithValue("?", comboBox1.Text); // Статус из выпадающего списка

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Партия зарегистрирована!");
                    ОбновитьТаблицуПартий();

                    // Очистка полей
                    textBox1.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка: проверьте, что введено число! " + ex.Message); }
        }

        // КНОПКА УДАЛИТЬ (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли вообще строка
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Сначала выберите строку в таблице!");
                return;
            }

            try
            {
                // Пытаемся взять значение из первой колонки (обычно это ID) 
                // или ищем по точному имени "id"
                object idValue = dataGridView1.CurrentRow.Cells[0].Value;

                if (idValue == null || idValue == DBNull.Value) return;

                int id = Convert.ToInt32(idValue);

                // Подтверждение удаления (чтобы не удалить случайно)
                DialogResult result = MessageBox.Show("Удалить партию №" + id + "?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        // Удаляем запись по ID
                        string sql = "DELETE FROM partii WHERE id = @id";
                        OleDbCommand cmd = new OleDbCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Партия удалена!");
                        ОбновитьТаблицуПартий();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: убедитесь, что колонка ID первая в таблице. Текст ошибки: " + ex.Message);
            }
        }

        // КНОПКА НАЗАД (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            new Form11().Show(); // Замени на нужную форму возврата
            this.Close();
        }
    }
}