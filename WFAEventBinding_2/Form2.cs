using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAEventBinding_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Yandınız");
        }

        private void label56_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Yandınız");
        }
    }
}
