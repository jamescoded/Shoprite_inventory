using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStock.controllers
{
    public class Product
    {
        private  int count = 0;
        public int id;
       public string category;
       public string product;
       public int quantity;
       public double unit_p;
         public double sale_p;
        private double gross_p;
        private double gross_s;
        private DateTime date;



        public Product(string category, string product, int quantity, double unit_p, double sale_p, double gross_p,
            double gross_s, DateTime date)
        {

            this.category = category;
            this.product = product;
            this.quantity = quantity;
            this.unit_p = unit_p;
            this.sale_p = sale_p;
            this.gross_p = gross_p;
            this.gross_s = gross_s;
            this.date = date;
            this.id = count;
            count++;
        }
        public Product(int id ,string category, string product, int quantity, double unit_p, double sale_p, double gross_p,
            double gross_s, DateTime date)
        {
            this.id=id;
            this.category = category;
            this.product = product;
            this.quantity = quantity;
            this.unit_p = unit_p;
            this.sale_p = sale_p;
            this.gross_p = gross_p;
            this.gross_s = gross_s;
            this.date=date;

            count++;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Cat
        {
            get { return category; }
            set { category = value; }
        }

        public string Prod
        {
            get { return product; }
            set { product = value; }
        }

        public int Quant
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Unit_p
        {
            get { return unit_p; }
            set { unit_p = value; }
        }

        public double Sal_p
        {
            get { return sale_p; }
            set { sale_p = value; }
        }

        public double Grosp
        {
            get { return gross_p; }
            set { gross_p = value; }
        }

        public double Grosss
        {
            get { return gross_s; }
            set { gross_s = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }

}

