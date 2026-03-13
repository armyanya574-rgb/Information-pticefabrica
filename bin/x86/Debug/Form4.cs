using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Загрузка данных в таблицу при открытии формы
            try
            {
                this.chehaTableAdapter.Fill(this.rUSSIAtwoDataSet2.cheha);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        // КНОПКА ДОБАВИТЬ (Проверь, что textBox1, 2, 3 существуют)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем новую строку на основе структуры таблицы
                DataRow newRow = rUSSIAtwoDataSet2.cheha.NewRow();

                // Заполняем поля из твоих TextBox
                newRow["Nazvanie"] = textBox1.Text;

                // Пробуем преобразовать текст в число для вместимости
                if (int.TryParse(textBox2.Text, out int vmest))
                {
                    newRow["Vmestimost"] = vmest;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите число в поле 'Вместимость'");
                    return;
                }

                newRow["Otvetstvenni"] = textBox3.Text;

                // Добавляем строку в DataSet
                rUSSIAtwoDataSet2.cheha.Rows.Add(newRow);

                // Сохраняем изменения в файл RUSSIAtwo.accdb
                this.chehaTableAdapter.Update(this.rUSSIAtwoDataSet2.cheha);

                MessageBox.Show("Запись добавлена в базу!");

                // Очищаем поля после добавления
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        // КНОПКА УДАЛИТЬ (Удаляет выделенную строку в таблице)
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Удаляем строку из визуального списка
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    // Синхронизируем с базой данных
                    this.chehaTableAdapter.Update(this.rUSSIAtwoDataSet2.cheha);
                    MessageBox.Show("Запись успешно удалена!");
                }
                else
                {
                    MessageBox.Show("Выберите строку для удаления в таблице");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
        }

        // КНОПКА ОБНОВИТЬ / ПЕРЕЗАГРУЗИТЬ
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.chehaTableAdapter.Fill(this.rUSSIAtwoDataSet2.cheha);
                MessageBox.Show("Данные обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить данные: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();

            f11.Show();


            this.Close();
        }
    }
}