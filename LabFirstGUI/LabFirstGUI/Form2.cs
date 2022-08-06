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
            
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                 Form1 Form1 = new Form1();
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
