namespace InventoryStock
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salereportbtn = new System.Windows.Forms.Button();
            this.addp = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.issueg = new System.Windows.Forms.Button();
            this.viewp = new System.Windows.Forms.Button();
            this.managep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salereportbtn
            // 
            this.salereportbtn.BackColor = System.Drawing.Color.LightBlue;
            this.salereportbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salereportbtn.Location = new System.Drawing.Point(3, 312);
            this.salereportbtn.Name = "salereportbtn";
            this.salereportbtn.Size = new System.Drawing.Size(219, 53);
            this.salereportbtn.TabIndex = 5;
            this.salereportbtn.Text = "Sale Report";
            this.salereportbtn.UseVisualStyleBackColor = false;
            this.salereportbtn.Click += new System.EventHandler(this.salereportbtn_Click);
            // 
            // addp
            // 
            this.addp.BackColor = System.Drawing.Color.LightBlue;
            this.addp.Location = new System.Drawing.Point(3, 106);
            this.addp.Name = "addp";
            this.addp.Size = new System.Drawing.Size(219, 43);
            this.addp.TabIndex = 2;
            this.addp.Text = "Add product";
            this.addp.UseVisualStyleBackColor = false;
            this.addp.Click += new System.EventHandler(this.addp_Click);
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.LightBlue;
            this.customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customers.Location = new System.Drawing.Point(3, 58);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(219, 42);
            this.customers.TabIndex = 1;
            this.customers.Text = "customers";
            this.customers.UseVisualStyleBackColor = false;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.LightBlue;
            this.employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employees.Location = new System.Drawing.Point(3, 3);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(219, 49);
            this.employees.TabIndex = 0;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 661);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.salereportbtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.employees, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.issueg, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.viewp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.managep, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // issueg
            // 
            this.issueg.BackColor = System.Drawing.Color.LightBlue;
            this.issueg.Location = new System.Drawing.Point(3, 256);
            this.issueg.Name = "issueg";
            this.issueg.Size = new System.Drawing.Size(219, 50);
            this.issueg.TabIndex = 8;
            this.issueg.Text = "Issue Goods";
            this.issueg.UseVisualStyleBackColor = false;
            this.issueg.Click += new System.EventHandler(this.issueg_Click);
            // 
            // viewp
            // 
            this.viewp.BackColor = System.Drawing.Color.LightBlue;
            this.viewp.Location = new System.Drawing.Point(3, 155);
            this.viewp.Name = "viewp";
            this.viewp.Size = new System.Drawing.Size(219, 45);
            this.viewp.TabIndex = 9;
            this.viewp.Text = "View Product";
            this.viewp.UseVisualStyleBackColor = false;
            this.viewp.Click += new System.EventHandler(this.viewp_Click);
            // 
            // managep
            // 
            this.managep.BackColor = System.Drawing.Color.LightBlue;
            this.managep.Location = new System.Drawing.Point(3, 208);
            this.managep.Name = "managep";
            this.managep.Size = new System.Drawing.Size(219, 42);
            this.managep.TabIndex = 10;
            this.managep.Text = "Manage Product";
            this.managep.UseVisualStyleBackColor = false;
            this.managep.Click += new System.EventHandler(this.managep_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 32);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 629);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addp;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button salereportbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button issueg;
        private System.Windows.Forms.Button viewp;
        private System.Windows.Forms.Button managep;
    }
}