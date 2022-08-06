using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LabFirstGUI
{
    public partial class Form1 : Form
    {
        
        public Form1(string username)
        {
            InitializeComponent();
            label8.Text = username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean x = false;
            product p = new product();
            Regex r = new Regex(@"^[0-9]+$");
            if (radioButton1.Checked)
                p.gender = 'M';
            else if (radioButton2.Checked)
                p.gender = 'F';
            else
            {
                errorProvider1.SetError(radioButton1, "choose gender");
                errorProvider1.SetError(radioButton2, "choose gender");
                x = true;
            }
            try
            {
              errorProvider1.Clear();
              p.number=int.Parse(textBox1.Text);

            }catch(Exception e1)
            {
                x= true;
                errorProvider1.SetError(textBox1, "Number is invalid");
            }
            try
            {
                errorProvider2.Clear();
                p.Inventory_number= int.Parse(textBox2.Text);
            }
            catch (Exception e2)
            {
                x= true;
                errorProvider2.SetError(textBox2, "Inventory Number is invalid");
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Object name is empty");
                x = true;
            }
            else
            {
                p.Object_name=textBox4.Text;
            }
            if (r.IsMatch(textBox3.Text))
            {
               p.count=int.Parse(textBox3.Text);
            }
            else
            {
                errorProvider1.SetError(textBox3, "count is invalid");
                x = true;
            }
            if (r.IsMatch(textBox5.Text))
            {
               p.price=int.Parse(textBox5.Text);
            }
            else
            {
                errorProvider1.SetError(textBox5, "price is invalid");
                x = true;
            }
            if (x == false)
            {
                p.date = dateTimePicker1.Text;
                p.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.Getproduct();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox5.Text = null;
            textBox3.Text=null;
    }

    
    }
    public class product
    {
       
        public String Object_name { get; set; }
        public char gender { get; set; }
        public int number { get; set; }
        public String date { get; set; }
        public Double Inventory_number { get; set; }
        public Double price { get; set; }
        public Double count { get; set; }

        static List<product> list = new List<product>();
        public void save()
        {
            list.Add(this);
            //MessageBox.Show($"Product {Object_name} Added");
        }
        public static List<product> Getproduct()
        {
            return list;
        }
    }
}
