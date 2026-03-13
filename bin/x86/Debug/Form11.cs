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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Show();


            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();


            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form7().Show(); // Или какая у тебя главная
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form8().Show(); // Или какая у тебя главная
            this.Close();
        }
    }
}
