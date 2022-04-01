using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passworder
{
    public partial class NewKVForm : Form
    {
        public NewKVForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "" || passwordHintTextBox.Text == "")
            {
                MessageBox.Show("Title or PasswordHint cannot be empty.");
                return;
            }

            Main main = (Main) this.Owner;
            if (!main.InsertPasswordData(titleTextBox.Text, passwordHintTextBox.Text))
            {
                MessageBox.Show("Title has already existed in Passworder.");
                return;
            }
            this.Dispose(true);
        }
    }
}
