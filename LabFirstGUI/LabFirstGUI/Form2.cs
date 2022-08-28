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
            product.list.Clear();
            sqlconnection.selectallpproduct(product.list);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (textBox1.Text != username)
            {
                errorProvider1.SetError(textBox1, "user name is invalid");
            }
            if (textBox2.Text != password)
            {
                errorProvider2.SetError(textBox2, "password is invalid");
            }
            if (textBox1.Text== username && textBox2.Text== password)
            {
                mainform Form1 = new mainform(username);
                this.Hide();
                Form1.Show();
            }
          
        }

    }
}
