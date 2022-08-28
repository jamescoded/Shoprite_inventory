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
    public partial class employesform : UserControl
    {
        private string url = "datasource=127.0.0.1;port=3307;username=root;password=;database=shopritedata";
        private MySqlConnection con;
        public employesform()
        {
            InitializeComponent();
            
        }

       

        public void Updateaccount()
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                MySqlDataAdapter datat = new MySqlDataAdapter(@"select * from account where type='user'" + "", con);
                DataTable employeData = new DataTable();
                MySqlDataAdapter datadmin = new MySqlDataAdapter(@"select * from account where type='admin'", con);
                DataTable admninData = new DataTable();

                datadmin.Fill(admninData);
                adminTable.DataSource = admninData;



                datat.Fill(employeData);






                employTable.DataSource = employeData;
                employTable.AllowUserToDeleteRows = true;

            }

        }

        public void hideupdate()
        {
            if (useru.Text == "" || addressu.Text == "" || contactu.Text == "" || emailu.Text == "" || typeu.Text == ""
               )
            {
                useru.Visible=false;
                addressu.Visible=false;
                contactu.Visible=false;
                emailu.Visible=false;
                typeu.Visible=false;
                passu.Visible=false;
                typeu.Visible = false;
                delete_a.Visible=false;
                updadress.Visible = false;
                updatep.Visible = false;
                updatype.Visible = false;
                updcont.Visible = false;
                updem.Visible = false;
                upduser.Visible = false;
                clear.Visible = false;
                label11.Text = "Please select account to use this section";
                opert.BackColor=Color.Honeydew;


            }
            else
            {
                useru.Visible = true;
                addressu.Visible = true;
                contactu.Visible = true;
                emailu.Visible = true;
                typeu.Visible = true;
                passu.Visible = true;
                typeu.Visible = true;
                delete_a.Visible = true;
                updadress.Visible = true;
                updatype.Visible = true;
                updatep.Visible = true;
                updcont.Visible=true;
                upduser.Visible=true;
                updem.Visible=true;
                clear.Visible=true;
                label11.Text = "AccountId";
                opert.BackColor = Color.GhostWhite;

            }


        }

        private void employesform_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "tbtn";
            btn.Text = "Update";
            btn.HeaderText = "Action";
            btn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btna = new DataGridViewButtonColumn();
        
            btna.Text = "Update";
            btna.HeaderText = "Action";
            btna.UseColumnTextForButtonValue = true;
            employTable.Columns.Add(btn);
            adminTable.Columns.Add(btna);
            accountype.Items.Add("user");
            accountype.Items.Add("admin");
            using (con = new MySqlConnection(url))
            {
                con.Open();
                MySqlDataAdapter datat = new MySqlDataAdapter(@"select * from account where type='user'" + "", con);
                DataTable employeData = new DataTable();
                MySqlDataAdapter datadmin = new MySqlDataAdapter(@"select * from account where type='admin'", con);
                DataTable admninData = new DataTable();

                datadmin.Fill(admninData);
                adminTable.DataSource = admninData;



                datat.Fill(employeData);






                employTable.DataSource = employeData;
                employTable.AllowUserToDeleteRows = true;

            }

            hideupdate();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query =

                    "UPDATE account SET contact=@v WHERE id=@v1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v", contactu.Text);
                cmd.Parameters.AddWithValue("v1", userId.Text);
                cmd.ExecuteNonQuery();
                Updateaccount();
                MessageBox.Show("User Contact updated !!", "update message", MessageBoxButtons.OK);
            }

        }

        private void employTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.RowIndex >=0)
            {
                DataGridView r = this.employTable;
              var username= r.Rows[e.RowIndex].Cells["username"].Value.ToString();
              var contact = r.Rows[e.RowIndex].Cells["contact"].Value.ToString();
              var address = r.Rows[e.RowIndex].Cells["address"].Value.ToString();
              var email= r.Rows[e.RowIndex].Cells["email"].Value.ToString();
              var type = r.Rows[e.RowIndex].Cells["type"].Value.ToString();
              var id = r.Rows[e.RowIndex].Cells["id"].Value.ToString();
              useru.Text = username;
              contactu.Text = contact;
              addressu.Text = address;
              emailu.Text = email;
              typeu.Text = type;
              userId.Text = id;
            }
            hideupdate();
        }

        private void adminTable_SelectionChanged(object sender, EventArgs e)
        {
         

        }

        private void opert_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query =

                    "UPDATE account SET type=@v  WHERE id=@v1";


                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v", typeu.Text);
                cmd.Parameters.AddWithValue("v1", userId.Text);
               
                
                
                cmd.ExecuteNonQuery();
                Updateaccount();
                MessageBox.Show("Account type updated !!", "update message", MessageBoxButtons.OK,MessageBoxIcon.Information);
             
            }
        }

        private void addressu_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeu_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactu_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query =

                    "UPDATE account SET address=@v  WHERE id=@v1";


                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v", addressu.Text);
                cmd.Parameters.AddWithValue("v1", userId.Text);
                cmd.ExecuteNonQuery();
                Updateaccount();
                MessageBox.Show("User Address updated !!", "update message", MessageBoxButtons.OK);
            }
        }

        private void delete_a_Click(object sender, EventArgs e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query =

                    "DELETE FROM account  WHERE id=@v1";


                MySqlCommand cmd = new MySqlCommand(query, con);
               
                cmd.Parameters.AddWithValue("v1", userId.Text);
               var result= MessageBox.Show("Please comfirm to deleted accounnt !!", "Special operation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                   cmd.ExecuteNonQuery();
                   Updateaccount();
                   MessageBox.Show("User Account deleted !!", "update message", MessageBoxButtons.OK);
                   
                       useru.Text = "";
                       addressu.Text = "";
                       contactu.Text = "";
                       emailu.Text = "";
                       typeu.Text = "";
                       userId.Text = "";
                     
               }
              
            }

        }

        private void adminTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView r = this.adminTable;
                var username = r.Rows[e.RowIndex].Cells["username"].Value.ToString();
                var contact = r.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                var address = r.Rows[e.RowIndex].Cells["address"].Value.ToString();
                var email = r.Rows[e.RowIndex].Cells["email"].Value.ToString();
                var type = r.Rows[e.RowIndex].Cells["type"].Value.ToString();
                var id = r.Rows[e.RowIndex].Cells["id"].Value.ToString();
                useru.Text = username;
                contactu.Text = contact;
                addressu.Text = address;
                emailu.Text = email;
                typeu.Text = type;
                userId.Text = id;
            }
            hideupdate();
        }

        private void upduser_Click(object sender, EventArgs e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query ="UPDATE account SET username=@v  WHERE id=@v1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v", useru.Text);
                cmd.Parameters.AddWithValue("v1", userId.Text);
                cmd.ExecuteNonQuery();
                Updateaccount();
                MessageBox.Show("Username updated !!", "update message", MessageBoxButtons.OK);




            }
        }

        private void updem_Click(object sender, EventArgs e)
        {

            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query =

                    "UPDATE account SET email=@v  WHERE id=@v1";


                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v", emailu.Text);
                cmd.Parameters.AddWithValue("v1", userId.Text);
                cmd.ExecuteNonQuery();
                Updateaccount();
                MessageBox.Show("User Email updated !!", "update message", MessageBoxButtons.OK);
            }
        }

        private void updatep_Click(object sender, EventArgs e)
        {
            using (con = new MySqlConnection(url))
            {
                con.Open();
                Auth pass = new Auth();
                string query =

                    "UPDATE account SET password=@v  WHERE id=@v1";


                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v",pass.EncodePassword(passu.Text));
                cmd.Parameters.AddWithValue("v1", userId.Text);
                cmd.ExecuteNonQuery();
                Updateaccount();
                MessageBox.Show("User Password updated !!", "update message", MessageBoxButtons.OK);
            }
        }

        private void userId_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            useru.Text = "";
            addressu.Text = "";
            contactu.Text = "";
            emailu.Text ="";
            typeu.Text ="";
            hideupdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            using (con = new MySqlConnection(url))
            {
                con.Open();
                string query = @"INSERT INTO account(username,contact,address,email,password,type)
VALUES (@v1,@v2,@v3,@v4,@v5,@v6)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("v1", username.Text);
                cmd.Parameters.AddWithValue("v2", contact.Text);
                cmd.Parameters.AddWithValue("v3", address.Text);
                cmd.Parameters.AddWithValue("v4", email.Text);

                cmd.Parameters.AddWithValue("v5", auth.EncodePassword(password.Text));
                cmd.Parameters.AddWithValue("v6", accountype.Text);
                if (username.Text =="" || contact.Text =="" || email.Text == "" || accountype.Text == "" ||
                    address.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields!!", "Requirement", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfully add!!", "Success", MessageBoxButtons.OK);


                    username.Text = "";
                    address.Text = "";
                    contact.Text = "";
                    password.Text = "";
                    email.Text = "";
                    accountype.Text = "";


                    Updateaccount();
                }

            }

        }
    }
}
