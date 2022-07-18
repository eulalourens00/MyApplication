using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мои_проекты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form3();
            frm.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                string password = Form2.Show("Авторизация", "Введите пароль:");

                if (password != "12345")
                {
                MessageBox.Show("Пароль неверный", "Плохой пароль", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();

                }

            

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();

        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
