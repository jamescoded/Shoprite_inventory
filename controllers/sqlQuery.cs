using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using MySql.Data.MySqlClient;

namespace InventoryStock.controllers
{
    public class sqlQuery
    {
      private  string url = "datasource=127.0.0.1;port=3307;username=root;password=;database=shopritedata";
      private MySqlConnection con;
        private Database db;
        public List<Product> good;
        public List<Product> product;
        public List<account> Accountm;




        /// <summary>
        /// Get all produts from database
        /// </summary>
        public void getProducts()
        {
            db = new Database();
            db.goodm();
             good = db.getgood();
            var query = "select * from products"; 
            con = new MySqlConnection(url);
          

            try
            {
                con.Open();
                Console.WriteLine("CONNECTED");
                MySqlCommand mc = new MySqlCommand(query, con);
                MySqlDataReader datafile = mc.ExecuteReader();
                if (datafile.HasRows)
                {
                    while (datafile.Read())
                    {
                        var id = datafile.GetInt32(0);
                        var cat = datafile.GetString(1);
                        var prod = datafile.GetString(2);
                        var quan = datafile.GetInt32(3);
                        var unitp = datafile.GetDouble(4);
                        var salep = datafile.GetDouble(5);
                        var grossp = datafile.GetDouble(6);
                        var grosss = datafile.GetDouble(7);
                        var date = datafile.GetDateTime(8);
                       
                        good.Add(new Product(id, cat, prod, quan, unitp, salep, grossp, grosss, date));

                    }

                    List<Product> store = good;
                    foreach (var VARIABLE in store)
                    {
                        Console.WriteLine(VARIABLE.Prod);
                    }



                }

con.Close();
            }
            catch (Exception e)
            {

            }
        }
        

      //// Insert products into database
      public void save_To_Database(Product p)
      {
          con = new MySqlConnection(url);
          Database db = new Database();
          db.addproduct(p);
          Console.WriteLine(db.getProduct().Count);

            try
          {
      product=db.getProduct();

        con.Open();
        string query =
                  "INSERT INTO products ( category, product, quantity, unit_price, sale_price, gross_sale, gross_price, date) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)";

              MySqlCommand cmd = new MySqlCommand(query, con);
              foreach (var item in product)
              {
                  cmd.Parameters.AddWithValue("@v1", item.Cat);
                  cmd.Parameters.AddWithValue("@v2", item.Prod);
                  cmd.Parameters.AddWithValue("@v3", item.Quant);
                  cmd.Parameters.AddWithValue("@v4", item.Unit_p);
                  cmd.Parameters.AddWithValue("@v5", item.Sal_p);
                  cmd.Parameters.AddWithValue("@v6", item.Grosp);
                  cmd.Parameters.AddWithValue("@v7", item.Grosss);
                  cmd.Parameters.AddWithValue("@v8", item.Date);

                }
             

                cmd.ExecuteNonQuery();

                Console.WriteLine("save");
            
              con.Close();
          }
          catch (Exception e)
          {
                Console.Write(e.ToString());
          }
      }










      public void addAccount(account a)
      {
          Database db= new Database();
          db.addAccounts();
          Accountm = db.getAccount();
          Accountm.Add(a);
          string gg = "INSERT INTO account (username,email, password, type) VALUES (@v1,@v2,@v3,@v4)";
          con = new MySqlConnection(url);
          MySqlCommand cmd= new MySqlCommand(gg, con);
          try
          {
              con.Open();
              foreach (var item in Accountm)
              {
                  cmd.Parameters.AddWithValue("@v1", item.Username);
                  cmd.Parameters.AddWithValue("@v2", item.Email);
                  cmd.Parameters.AddWithValue("@v3", item.Password);
                  cmd.Parameters.AddWithValue("@v4", item.Type);
                  
                }

              cmd.ExecuteNonQuery();
              Console.WriteLine("ok saved");
              con.Close();
          }
          catch (Exception e)
          {
              Console.WriteLine(e);
              
          }


      }

      
    }
    }
