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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form2 adminForm = new Form2();
                adminForm.Show();
                this.Hide(); // Скрываем первую форму
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль администратора!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                // 2. Сравниваем введенные данные с теми, что сохранены в Form4
                // Мы обращаемся к переменным через имя класса Form4
                if (textBox1.Text == Form10.registeredLogin && textBox2.Text == Form10.registeredPass)
                {
                    // Если логин и пароль совпали — пускаем в кабинет клиента (Form3)
                    Form3 clientForm = new Form3();
                    clientForm.Show();
                    this.Hide();
                }
                else
                {
                    // Если данные не совпали или регистрация еще не была пройдена
                    MessageBox.Show("Ошибка: Неверный логин/пароль или вы еще не зарегистрированы!");
                }
            }
            else
            {
                // Если пользователь вообще ничего не ввел
                MessageBox.Show("Пожалуйста, введите логин и пароль!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 regForm = new Form4();
            regForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                // 2. Сравниваем введенные данные с теми, что сохранены в Form4
                // Мы обращаемся к переменным через имя класса Form4
                if (textBox1.Text == Form10.registeredLogin && textBox2.Text == Form10.registeredPass)
                {
                    // Если логин и пароль совпали — пускаем в кабинет клиента (Form3)
                    Form3 clientForm = new Form3();
                    clientForm.Show();
                    this.Hide();
                }
                else
                {
                    // Если данные не совпали или регистрация еще не была пройдена
                    MessageBox.Show("Ошибка: Неверный логин/пароль или вы еще не зарегистрированы!");
                }
            }
            else
            {
                // Если пользователь вообще ничего не ввел
                MessageBox.Show("Пожалуйста, введите логин и пароль!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form10 regForm = new Form10();
            regForm.Show();
            this.Hide();
        }
    }
}