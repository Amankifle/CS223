using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabFirstGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";

            if (textBox1.Text== username && textBox2.Text== password)
            {
                 Form1 Form1 = new Form1(username);
                this.Hide();
                Form1.Show();
            }
            else
            {
                errorProvider1.SetError(textBox1, "user name is invalid");
            }
        }
    }
}
