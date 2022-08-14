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

        
private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = product.Getproduct();
        }
    }
}
