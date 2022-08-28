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
    public partial class viewform : Form
    {
        
        public viewform()
        {
            InitializeComponent(); 
        }


        private void viewform_Load(object sender, EventArgs e)
        {
           int n=sqlconnection.getTotalproduct();
            if (n < 1)
                MessageBox.Show("No product has been added.");
            else { 
            flowLayoutPanel1.Controls.Clear();
                foreach (var item in product.Getproduct())
                {
                    productcard p = new productcard();
                    p.Product = item.Object_name;
                    p.Product1 = item.number.ToString();
                    p.Product2 = item.Inventory_number.ToString();
                    p.Product3 = item.date;
                    p.Product4 = item.price.ToString();
                    p.Click += card_click;
                    p.Click += (object s, EventArgs e1) =>{
                       
                    };
                    flowLayoutPanel1.Controls.Add(p);
                }
            }
        }
        private void card_click(object sender, EventArgs e)
        {
            MessageBox.Show("");

        }

    }
}
