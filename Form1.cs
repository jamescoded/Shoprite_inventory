using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryStock.controllers;

namespace InventoryStock
{
    public partial class Login : Form
    {
        private Form2 ff;
        private Database db;
        private sqlQuery sqlm;

        public String account_type;
        public bool isLogIn { get; set; }
        public Login()
        {
            InitializeComponent();
            ff = new Form2();

        }

        private void Login_Load(object sender, EventArgs e)
        {
             db=new Database();
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          


        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            //this.Close();

            //isLogIn = true;
            Product pp = new Product("veg", "orange", 13, 1.2, 2.5, 30.00, 40.00, new DateTime());

            Database db = new Database();
            sqlm = new sqlQuery();


            //   sqlm.save_To_Database(pp);


            //  sqlm.getProducts();
            // sqlm.good.Count;

            // addAccount
            //sqlm.addAccount(new account("admin","mencoded@gmail.com","manifest@1","himgo"));














        }
    }
}
