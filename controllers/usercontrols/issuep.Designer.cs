namespace InventoryStock.controllers.usercontrols
{
    partial class issues
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.quant = new System.Windows.Forms.TextBox();
            this.store = new System.Windows.Forms.ComboBox();
            this.proname = new System.Windows.Forms.ComboBox();
            this.proid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.selp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cartt = new System.Windows.Forms.DataGridView();
            this.cart = new System.Windows.Forms.GroupBox();
            this.reload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartt)).BeginInit();
            this.cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Section";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.customer);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.quant);
            this.groupBox1.Controls.Add(this.store);
            this.groupBox1.Controls.Add(this.proname);
            this.groupBox1.Controls.Add(this.proid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teller";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(603, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer
            // 
            this.customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customer.Location = new System.Drawing.Point(603, 28);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(138, 26);
            this.customer.TabIndex = 11;
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.price.Location = new System.Drawing.Point(383, 74);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 26);
            this.price.TabIndex = 10;
            // 
            // quant
            // 
            this.quant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quant.Location = new System.Drawing.Point(383, 28);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(100, 26);
            this.quant.TabIndex = 9;
            // 
            // store
            // 
            this.store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.store.FormattingEnabled = true;
            this.store.Location = new System.Drawing.Point(603, 73);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(138, 27);
            this.store.TabIndex = 8;
            this.store.SelectedIndexChanged += new System.EventHandler(this.store_SelectedIndexChanged);
            // 
            // proname
            // 
            this.proname.FormattingEnabled = true;
            this.proname.Location = new System.Drawing.Point(107, 75);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(121, 27);
            this.proname.TabIndex = 7;
            this.proname.SelectedIndexChanged += new System.EventHandler(this.proname_SelectedIndexChanged);
            // 
            // proid
            // 
            this.proid.FormattingEnabled = true;
            this.proid.Location = new System.Drawing.Point(79, 25);
            this.proid.Name = "proid";
            this.proid.Size = new System.Drawing.Size(149, 27);
            this.proid.TabIndex = 6;
            this.proid.SelectedIndexChanged += new System.EventHandler(this.proid_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Vendor";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price  GH¢";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Productid";
            // 
            // selp
            // 
            this.selp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selp.BackgroundColor = System.Drawing.Color.White;
            this.selp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selp.Location = new System.Drawing.Point(18, 410);
            this.selp.Name = "selp";
            this.selp.Size = new System.Drawing.Size(761, 153);
            this.selp.TabIndex = 3;
            this.selp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selp_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Selection";
            // 
            // cartt
            // 
            this.cartt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cartt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartt.Location = new System.Drawing.Point(28, 25);
            this.cartt.Name = "cartt";
            this.cartt.Size = new System.Drawing.Size(697, 101);
            this.cartt.TabIndex = 1;
            // 
            // cart
            // 
            this.cart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cart.Controls.Add(this.cartt);
            this.cart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart.Location = new System.Drawing.Point(18, 229);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(761, 132);
            this.cart.TabIndex = 2;
            this.cart.TabStop = false;
            this.cart.Text = "Cart Section";
            // 
            // reload
            // 
            this.reload.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload.Location = new System.Drawing.Point(125, 13);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 23);
            this.reload.TabIndex = 5;
            this.reload.Text = "Refresh";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // issues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.reload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selp);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "issues";
            this.Size = new System.Drawing.Size(808, 566);
            this.Load += new System.EventHandler(this.issues_Load);
            this.Click += new System.EventHandler(this.proname_SelectedIndexChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartt)).EndInit();
            this.cart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView selp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quant;
        private System.Windows.Forms.ComboBox store;
        private System.Windows.Forms.ComboBox proname;
        private System.Windows.Forms.ComboBox proid;
        private System.Windows.Forms.DataGridView cartt;
        private System.Windows.Forms.GroupBox cart;
        private System.Windows.Forms.Button reload;
    }
}
