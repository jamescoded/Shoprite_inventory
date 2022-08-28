using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryStock.controllers.usercontrols
{
    public partial class viewp : UserControl
    {
        private string url = "datasource=127.0.0.1;port=3307;username=root;password=;database=shopritedata";
        private MySqlConnection con;
        private DataGridViewButtonColumn btn;
        public viewp()
        {

            
            InitializeComponent();
        
        }

        private void UpdateP()
        {
            using (con=new MySqlConnection(url))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS";
                MySqlDataAdapter newAdapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                newAdapter.Fill(dt);
                productstable.DataSource= dt;
             


            }

        }
        private void Updatecat(string e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS where Category='"+e+"'";
                MySqlDataAdapter newAdapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                newAdapter.Fill(dt);
                productstable.DataSource = dt;



            }

        }
        private void Updates(string e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "SELECT * FROM PRODUCTS where Status='" + e + "'";
                MySqlDataAdapter newAdapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                newAdapter.Fill(dt);
                productstable.DataSource = dt;



            }

        }



        private void searchbyall()
        {
         

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Category");
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");

            dt.Columns.Add("Available good");

            dt.Columns.Add("Unit price");
            dt.Columns.Add("Sale price");
            dt.Columns.Add("Gross Price");
            dt.Columns.Add("Gross Sale");
            dt.Columns.Add("Status");
            dt.Columns.Add("Vendor");
            dt.Columns.Add("Date");
      



            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = @"SELECT * FROM PRODUCTS WHERE id=@v OR Category=@v OR Product=@v OR Quantity=@v OR 
Available_goods=@v OR Unit_price=@v OR Sale_price=@v OR Gross_sale=@v OR Gross_price=@v OR Status=@v OR Vendor=@v
";
                MySqlCommand cmd= new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@v", searchall.Text);

                MySqlDataReader dr =cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                    
                        dt.Rows.Add(dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetInt32(3),dr.GetInt32(4),dr.GetDouble(5), dr.GetDouble(6),
                            dr.GetDouble(7), dr.GetDouble(8),dr.GetString(9),dr.GetString(11)
                            );
                       

                    } 
                }
                productstable.DataSource=dt;
              


            }

        }
        public void fill_combo()
        {
            List<string> newc = new List<string>();
            List<string> news = new List<string>();
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = "select Category,Status from products";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (! newc.Contains(data.GetString(0)))
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
                filterby.Items.Add(c);
            }
            foreach (string c in news)
            {
                status.Items.Add(c);
            }
        }
        private void viewp_Load(object sender, EventArgs e)
        {
            filterby.SelectedText = "Category";
            status.SelectedText = "Select";
            fill_combo();
            UpdateP();



        }

        private void productstable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            searchbyall();

        }

        private void filterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            Updatecat(filterby.Text);

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            Updates(status.Text);
        }


        public void zpt()
        {
            PrintDialog pd = new PrintDialog();
           
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Arial", 10);
            PaperSize psz = new PaperSize("Custom", 100, 200);
            printDialog1.Document = printProducts;
            printDialog1.Document.DefaultPageSettings.PaperSize = psz;
            printProducts.DefaultPageSettings.PaperSize.Height = 820;
            printProducts.DefaultPageSettings.PaperSize.Width = 700;
            printProducts.PrintPage += new PrintPageEventHandler(printProducts_PrintPage);
            DialogResult res = printDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                PrintPreviewDialog prv = new PrintPreviewDialog();
                prv.Document = printProducts;
                res = prv.ShowDialog();
                if (res == DialogResult.OK)
                {
                    printProducts.Print();
                }
            }

        }

        private void printProducts_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 65;
            int Offset = 80;
            graphics.DrawString("Shoprite All Stock Products", new Font("Courier New", 10), new SolidBrush(Color.Black),
                startX, startY + Offset);
            Offset = Offset + 20;
            string underLine = "------------------------------------------------------------------------------------";
            Offset = Offset + 30;
          
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX,
                startY + Offset);
            Offset = Offset + 20;
            int a = productstable.Rows.Count;
            int c = 0;
            graphics.DrawString("Id", new Font("Courier New", 10), new SolidBrush(Color.Black),
                startX, startY + Offset);

            graphics.DrawString("Category", new Font("Courier New", 10),
                   new SolidBrush(Color.Black), startX + 30, startY + Offset);

            graphics.DrawString("Product", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 130, startY + Offset);

            graphics.DrawString("Qty", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 200, startY + Offset);
            graphics.DrawString("Aval", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 250, startY + Offset);
            graphics.DrawString("U_price(GHC)", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 300, startY + Offset);

            graphics.DrawString(" S_price(GHC)", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 410, startY + Offset);

            graphics.DrawString("G_Price(GHC)", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 530, startY + Offset);

           

            graphics.DrawString("G_Sale(GHC)", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 650, startY + Offset);

            graphics.DrawString("Status", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 750, startY + Offset);

           


            graphics.DrawString("Vendor", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 880, startY + Offset);

            Offset = Offset + 40;
            for (int i = 0; i < a; i++)
            {
               
                    graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[0].Value), new Font("Courier New", 10),
                        new SolidBrush(Color.Black), startX, startY + Offset);
                  
                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[1].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX+30, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[2].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 130, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[3].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 200, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[4].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 270, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[5].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX +330, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[6].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX +450, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[7].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 560, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[8].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 650, startY + Offset);

                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[9].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 750, startY + Offset);



                graphics.DrawString(Convert.ToString(productstable.Rows[i].Cells[11].Value), new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX + 890, startY + Offset);

                Offset = Offset + 20;
              
            }

            Offset = Offset + 20;
            Offset = Offset + 20;
            graphics.DrawString("CEO : James mensah", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + Offset);
            graphics.DrawString("Signed By ______________________________", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 700, startY + Offset);
            Offset = Offset + 20;
            Offset = Offset + 20;
            graphics.DrawString("Signature ______________________________", new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX + 700, startY+ Offset);


        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            zpt();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            UpdateP();
        }
    }
}
