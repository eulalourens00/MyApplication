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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string  windowTitle, string message)
        {
            InitializeComponent();
            this.Text = windowTitle;
            label1.Text = message;
            
        }

        public static string Show(string windowTitle, string message)
        {
            using(Form2 inputDlg = new Form2(windowTitle, message))
            {
                inputDlg.ShowDialog();
                return inputDlg.textBox1.Text;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
