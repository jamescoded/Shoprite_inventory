using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryStock.controllers.usercontrols
{
    public partial class addpro : UserControl
    {
        private string url = "datasource=127.0.0.1;port=3307;username=root;password=;database=shopritedata";
        private MySqlConnection con;


        public addpro()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addpro_Load(object sender, EventArgs e)
        {
            cat.SelectedText = "Add or select"
                ;
            List<string>newli=new List<string>();
            using (con = new MySqlConnection(url))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select Category from products", con);
                MySqlDataReader data=cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (!newli.Contains(data.GetString(0)))
                        {
                            newli.Add(data.GetString(0));
                        }
                    }
                }
                data.Close();
            }

            foreach (var item in newli)
            {
                cat.Items.Add(item);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

      

        private void quan_TextChanged(object sender, EventArgs e)
        {
            if (unit.Text != "")
            {
                var a=Int32.Parse(unit.Text.Trim());
                var b = Int32.Parse(quan.Text.Trim());
                grossp.Text = (a * b).ToString();

            }
            if (sale.Text != "")
            {
                var a = Int32.Parse(sale.Text.Trim());
                var b = Int32.Parse(quan.Text.Trim());
                grosss.Text = (a * b).ToString();

            }

            ava.Text = quan.Text;
        }

        private void unit_TextChanged(object sender, EventArgs e)
        {

            if (quan.Text != "")
            {
                var a = Int32.Parse(unit.Text.Trim());
                var b = Int32.Parse(quan.Text.Trim());
                grossp.Text = (a * b).ToString();

            }
        }

        private void vendor_TextChanged(object sender, EventArgs e)
        {

        }

        private void sale_TextChanged(object sender, EventArgs e)
        {
            if (quan.Text != "")
            {
                var a = Int32.Parse(sale.Text.Trim());
                var b = Int32.Parse(quan.Text.Trim());
                grosss.Text = (a * b).ToString();

            }
        }

        private void grossp_TextChanged(object sender, EventArgs e)
        {

        }

        private void grosss_TextChanged(object sender, EventArgs e)
        {

        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addb_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (con = new MySqlConnection(url))
                {
                    con.Open();
                    string query =
                        "INSERT INTO products(Category, Product, Quantity,Available_goods,Unit_price,Sale_price, Gross_sale, Gross_price,Vendor) VALUES ('" +
                        cat.Text + "','" + productt.Text + "','" + quan.Text + "','" + ava.Text + "','" + unit.Text +
                        "','" + sale.Text + "','" + grosss.Text + "','" + grossp.Text + "','" + vendor.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (
                        cat.Text == "" || productt.Text == "" || quan.Text == "" || ava.Text == "" || unit.Text == ""
                        || sale.Text == "" || grosss.Text == "" || grossp.Text == "" || vendor.Text == ""
                    )
                    {
                        MessageBox.Show("Please fill all the fields to Contnue", "failed", MessageBoxButtons.OK);
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Successfully Add to Shoprite Store","Success",MessageBoxButtons.OK);

                    }


                   

                }
            }
            catch (Exception r)
            {
                MessageBox.Show(@"message :: '" + r+ "'", "Error", MessageBoxButtons.OK);
            }
        }

        private void viewall_Click(object sender, EventArgs e)
        {
          

        }

        private void productt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
