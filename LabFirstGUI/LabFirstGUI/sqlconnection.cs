using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace LabFirstGUI
{
    internal class sqlconnection
    {
        static SqlConnection conn;
        public static void sqlconn()
        {
            
            try
            {
                string path = @"server=.;database=product_project;integrated security=true";
                conn = new SqlConnection(path);
                conn.Open();
                //MessageBox.Show("connected");
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message); 
            }
            
        }
        public static void insertpproduct(product p)
        {
            string insertquery = "insert into product values('" + p.Object_name + "', '" + p.gender + "', '" + p.number + "', '" + p.date + "', '" + p.Inventory_number + "', '" + p.price + "', '" + p.count + "')";
            try
            {
                sqlconn();
                SqlCommand cmd = new SqlCommand(insertquery, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"Product { p.Object_name} has been Added Successfully");
                //conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        public static void selectallpproduct(List<product> temp)
        {
            
            try
            {
                sqlconn();
                SqlCommand cmd = new SqlCommand("select * from product", conn);
                SqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    product p = new product();
                    p.Object_name = res["objectname"].ToString();
                    char[] g = res[1].ToString().ToCharArray();
                    p.gender = g[0];
                    p.number = int.Parse(res[2].ToString());
                    p.date = res[3].ToString();
                    p.Inventory_number = double.Parse(res[4].ToString());
                    p.price = double.Parse(res[5].ToString());
                    p.count = double.Parse(res[6].ToString());
                    temp.Add(p);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
        static public int getTotalproduct()
        {
            sqlconn();
            string query = "select count(*) from product";
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
               
                int n = (int)cmd.ExecuteScalar();
                return n;
            }
        }

    }
}
