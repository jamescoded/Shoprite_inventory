using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventoryStock.controllers
{
    public class Database
    {
        private List<Product> good;
        private List<Product> ProductList;
        private List<account> Account;
        private Product Pro;
        
         


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void goodm()
        {
            good=new List<Product>(100);
          
        }

        
        public List<Product> getgood()
        {
            
            return good; 
        }

        public void addAccounts()
        {
            Account = new List<account>();
        }

        public List<account> getAccount()
        {
            return
                Account;
        }


        public void addproduct(Product p)
        {
            ProductList = new List<Product>();
            ProductList.Add(p);

        }
        public List<Product> getProduct()
        {
            return ProductList;
        }





    }
    
}
