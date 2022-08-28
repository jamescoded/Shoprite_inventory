using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryStock.controllers.usercontrols;

namespace InventoryStock
{
    public partial class Form2 : Form
    {
        private Navigator nav;
        public Form2()
        {
            InitializeComponent();
            initializeform();
        }



        private void initializeform()
        {
            List<UserControl> list = new List<UserControl>() {new employesform(),new customer(),new addpro(),new viewp(),new manage(),new issues(),new records()};
             nav = new Navigator(list,panel3);
            nav.addcontrol();
            nav.Display(0);
            employees.BackColor = Color.White;
        }
        


        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

        private void menu_Enter(object sender, EventArgs e)
        {

        }

        private void cuspanel_Enter(object sender, EventArgs e)
        {

        }

        private void employees_Click(object sender, EventArgs e)
        {
           
            nav.Display(0);

            employees.BackColor = Color.White;
            customers.BackColor = Color.LightBlue;
            viewp.BackColor = Color.LightBlue;
            managep.BackColor = Color.LightBlue;
            addp.BackColor = Color.LightBlue;
            issueg.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            salereportbtn.BackColor = Color.LightBlue;


        }

        private void customers_Click(object sender, EventArgs e)
        {

            nav.Display(1);
            issueg.BackColor = Color.LightBlue;
            employees.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            viewp.BackColor = Color.LightBlue;
            managep.BackColor = Color.LightBlue;
            addp.BackColor = Color.LightBlue;

      
            customers.BackColor = Color.White;
            salereportbtn.BackColor = Color.LightBlue;
        }

        private void addp_Click(object sender, EventArgs e)
        {
            nav.Display(2);
            addp.BackColor = Color.White;
            employees.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            viewp.BackColor = Color.LightBlue;
            managep.BackColor = Color.LightBlue;
        
            issueg.BackColor =Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            salereportbtn.BackColor = Color.LightBlue;
        }

        private void viewp_Click(object sender, EventArgs e)
        {

            nav.Display(3);
            viewp.BackColor = Color.White;
            employees.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            
            managep.BackColor = Color.LightBlue;
            addp.BackColor = Color.LightBlue;
            issueg.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            salereportbtn.BackColor = Color.LightBlue;

        }

        private void managep_Click(object sender, EventArgs e)
        {

            nav.Display(4);
            managep.BackColor = Color.White;
            employees.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            viewp.BackColor = Color.LightBlue;
          
            addp.BackColor = Color.LightBlue;
            issueg.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            salereportbtn.BackColor = Color.LightBlue;
        }

        private void issueg_Click(object sender, EventArgs e)
        {
            issueg.BackColor = Color.White;
            nav.Display(5);
            employees.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            viewp.BackColor = Color.LightBlue;
            managep.BackColor = Color.LightBlue;
            addp.BackColor = Color.LightBlue;
           
            customers.BackColor = Color.LightBlue;
            salereportbtn.BackColor = Color.LightBlue;
        }

        private void salereportbtn_Click(object sender, EventArgs e)
        {
            nav.Display(6);
            salereportbtn.BackColor = Color.White;
            employees.BackColor = Color.LightBlue;
            customers.BackColor = Color.LightBlue;
            viewp.BackColor = Color.LightBlue;
            managep.BackColor = Color.LightBlue;
            addp.BackColor = Color.LightBlue;
            issueg.BackColor =Color.LightBlue;
            customers.BackColor = Color.LightBlue;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
