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
    public partial class Form8 : Form
    {
        string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\RUSSIAtwo.accdb";

        public Form8()
        {
            InitializeComponent();
            this.Load += (s, e) => ОбновитьТаблицуПород();
        }

        private void ОбновитьТаблицуПород()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM poroda", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка загрузки: " + ex.Message); }
        }

        // КНОПКА ДОБАВИТЬ (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка: заполнено ли название и выбран ли тип в списке
            if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Введите название и выберите тип направления!");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    // Поля: Nazporodi, Tipnapravlenia, SrokVirachivania
                    string sql = "INSERT INTO poroda (Nazporodi, Tipnapravlenia, SrokVirachivania) VALUES (?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("?", textBox1.Text); // Название
                    cmd.Parameters.AddWithValue("?", comboBox1.Text); // Выбор из списка (Мясное/Яичное)

                    // Проверка на число в сроке выращивания (textBox3)
                    if (int.TryParse(textBox3.Text, out int srok))
                    {
                        cmd.Parameters.AddWithValue("?", srok);
                    }
                    else
                    {
                        MessageBox.Show("Введите число в поле 'Срок выращивания'!");
                        return;
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новая порода '" + textBox1.Text + "' добавлена!");

                    textBox1.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1; // Сброс выбора
                    ОбновитьТаблицуПород();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); }
        }

        // КНОПКА УДАЛИТЬ (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            try
            {
                // Берем ID из первой колонки
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    new OleDbCommand($"DELETE FROM poroda WHERE id = {id}", conn).ExecuteNonQuery();
                    ОбновитьТаблицуПород();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка удаления: " + ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Close();
        }
    }
}