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
    public partial class productcard : UserControl
    {
        private String _product;

        public String Product
        {
            get { return _product; }
            set { _product = value;label1.Text = value; }
        }
        private String _product1;

        public String Product1
        {
            get { return _product1; }
            set { _product1 = value; label2.Text = value; }
        }
        private String _product2;

        public String Product2
        {
            get { return _product2; }
            set { _product2 = value; label3.Text = value; }
        }
        private String _product3;

        public String Product3
        {
            get { return _product3; }
            set { _product3 = value; label4.Text = value; }
        }
        private String _product4;

        public String Product4
        {
            get { return _product4; }
            set { _product4 = value; label5.Text = value; }
        }

        public productcard()
        {
            InitializeComponent();
        }

        private void productcard_Load(object sender, EventArgs e)
        {

        }
    }
}
