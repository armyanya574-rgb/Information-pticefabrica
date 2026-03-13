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
    public partial class Form10 : Form
    {
        public static string registeredLogin = "";
        public static string registeredPass = "";
        public Form10()

        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            // 2. Сохраняем данные в переменные Form1
            Form10.registeredLogin = textBox1.Text;
            Form10.registeredPass = textBox2.Text;

            MessageBox.Show("Регистрация прошла успешно!");

            // 3. Закрываем эту форму и возвращаемся на первую
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}



