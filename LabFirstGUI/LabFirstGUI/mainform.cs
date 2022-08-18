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
    public partial class mainform : Form
    {
         
        string name;
        public mainform(string username)
        {
            InitializeComponent();
            name = username;
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form = new Form1(name);
            form.MdiParent = this;
            form.Show();
        }

        private void viewAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            viewform viewform = new viewform();
            viewform.MdiParent = this;
            viewform.Show(); 
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Show();
            
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            searchform searchform = new searchform();
            searchform.MdiParent = this;
            searchform.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            addNewProductToolStripMenuItem_Click(sender, e);
            addNewProductToolStripMenuItem.Enabled=true;
        }
    }
}
