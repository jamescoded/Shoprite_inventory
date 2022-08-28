using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryStock.controllers.usercontrols
{
    public partial class issues : UserControl
    {
        private DataTable dt;
        private string url = "datasource=127.0.0.1;port=3307;username=root;password=;database=shopritedata";
        private MySqlConnection con;
        private DataGridViewButtonColumn btn;
        private string aval;
        public issues()
        {
            InitializeComponent();
        }


        private void UpdateP()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "tbtn";
            btn.Text = "Select";
            btn.HeaderText = "Sale Button";
            btn.UseColumnTextForButtonValue = true;
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS";
                MySqlDataAdapter newAdapter = new MySqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                newAdapter.Fill(dta);
                selp.Columns.Add(btn);

                selp.DataSource = dta;
               



            }

        }
        private void selectp(string e)
        {
            List<string> v = new List<string>(); 
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "tbtn";
            btn.Text = "Select";
            btn.HeaderText = "Sale Button";
            btn.UseColumnTextForButtonValue = true;
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS where Product='" + e + "'";
                MySqlDataAdapter newAdapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                newAdapter.Fill(dt);
                
                selp.DataSource = dt;
                int index = 0;
                if (selp.Rows.Count > 0)
                {
                    DataGridView r = selp;
                    foreach (var i in selp.Columns)
                    {
                        var vendd = r.Rows[index].Cells["Vendor"].Value.ToString();

                        if (!v.Contains(vendd))
                        {
                            v.Add(vendd);
                        }
                    }
                }
                store.Items.Clear();
                foreach (var VARIABLE in v)
                {
                   store.Items.Add(VARIABLE);

                }
                if (store.Items.Count < 1)
                {
                    
                    store.SelectedText = "unknown vendor!!";
                }

            }

        }
        private void Vendor(string e)
        {
            List<string> v = new List<string>();
           
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS where Vendor='" + e + "'";
                MySqlDataAdapter newAdapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                newAdapter.Fill(dt);

                selp.DataSource = dt;
                int index = 0;
                if (selp.Rows.Count > 0)
                {
                    DataGridView r = selp;
                    foreach (var i in selp.Columns)
                    {
                        var vendd = r.Rows[index].Cells["Product"].Value.ToString();

                        if (!v.Contains(vendd))
                        {
                            v.Add(vendd);
                        }
                    }
                }
                proname.Items.Clear();
                foreach (var VARIABLE in v)
                {
                    proname.Items.Add(VARIABLE);

                }
                if (proname.Items.Count <1)
                {
                    proname.SelectedText = "No product found!!";
                }

            }

        }
        public void fill_combo()
        {
            proname.SelectedText = "select..";
            store.SelectedText = "select..";
            List<string> newc = new List<string>();
            List<string> news = new List<string>();
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "select Product,Vendor from products";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (!newc.Contains(data.GetString(0)))
                        {
                            newc.Add(data.GetString(0));
                        }

                        if (!news.Contains(data.GetString(1)))
                        {
                            news.Add(data.GetString(1));
                        }

                    }
                }

            }

            foreach (string c in newc)
            {
                proname.Items.Add(c);
            }
            foreach (string c in news)
            {
                store.Items.Add(c);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void issues_Load(object sender, EventArgs e)
        {
            carts();
            UpdateP();
            fill_combo();
        }

        private void selp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView r = this.selp;
                var id = r.Rows[e.RowIndex].Cells["id"].Value.ToString();
               
                var pro = r.Rows[e.RowIndex].Cells["Product"].Value.ToString();
                var quan = r.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                aval= r.Rows[e.RowIndex].Cells["Available_goods"].Value.ToString();
                var salp = r.Rows[e.RowIndex].Cells["Sale_price"].Value.ToString();
                var ven = r.Rows[e.RowIndex].Cells["Vendor"].Value.ToString();
                proid.Text = id;
                proname.Text = pro;
                quant.Text= quan;
                price.Text = salp;
                store.Text = ven;

            }

        }

        private void proname_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   selectp(proname.Text);
           
        }

        private void reload_Click(object sender, EventArgs e)
        {
            UpdateP();
            proname.Items.Clear();
            store.Items.Clear();
            proname.SelectedText = "select..";
            store.SelectedText = "select..";
            fill_combo();
        }

        private void store_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Vendor(store.Text);
            
        }

        private void proid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carts()
        {
            dt=new DataTable();
            dt.Columns.Add("ID");
           
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Sale price ()");
            dt.Columns.Add("Store");
            
            cartt.DataSource = dt;

            
        }
        private void Addcarts()
        {
            cartt.AllowUserToAddRows = true;
            dt.Rows.Add(proid.Text, proname.Text, quant.Text, price.Text, store.Text);
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addcarts();
        }
    }
}