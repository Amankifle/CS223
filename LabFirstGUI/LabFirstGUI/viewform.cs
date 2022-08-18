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
            if (product.list.Count < 1)
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
                    flowLayoutPanel1.Controls.Add(p);
                }
            }
        }
    }
}
