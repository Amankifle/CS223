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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product p = new product
     { Object_name = textBox4.Text,number = int.Parse(textBox1.Text),date = dateTimePicker1.Text,Inventory_number = int.Parse(textBox2.Text),price = double.Parse(textBox5.Text),count = double.Parse(textBox3.Text)};
            p.save();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class product
    {
        public String Object_name { get; set; }
        public int number { get; set; }
        public String date { get; set; }
        public Double Inventory_number { get; set; }
        public Double price { get; set; }
        public Double count { get; set; }
        public void save()
        {
            MessageBox.Show($"Product {Object_name} Added");
        }
    }
}
