namespace InventoryStock.controllers.usercontrols
{
    partial class viewp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.operstock = new System.Windows.Forms.GroupBox();
            this.printbtn = new System.Windows.Forms.Button();
            this.findbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.filterby = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.productstable = new System.Windows.Forms.DataGridView();
            this.printProducts = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.refresh = new System.Windows.Forms.Button();
            this.operstock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productstable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "All  Stock Product";
            // 
            // operstock
            // 
            this.operstock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operstock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.operstock.Controls.Add(this.printbtn);
            this.operstock.Controls.Add(this.findbtn);
            this.operstock.Controls.Add(this.label4);
            this.operstock.Controls.Add(this.label3);
            this.operstock.Controls.Add(this.searchall);
            this.operstock.Controls.Add(this.label2);
            this.operstock.Controls.Add(this.status);
            this.operstock.Controls.Add(this.filterby);
            this.operstock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operstock.ForeColor = System.Drawing.Color.White;
            this.operstock.Location = new System.Drawing.Point(33, 64);
            this.operstock.Name = "operstock";
            this.operstock.Size = new System.Drawing.Size(841, 95);
            this.operstock.TabIndex = 1;
            this.operstock.TabStop = false;
            this.operstock.Text = "Operation Control";
            // 
            // printbtn
            // 
            this.printbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printbtn.BackColor = System.Drawing.Color.Crimson;
            this.printbtn.BackgroundImage = global::InventoryStock.Properties.Resources.adminn;
            this.printbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.Location = new System.Drawing.Point(748, 26);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(93, 50);
            this.printbtn.TabIndex = 4;
            this.printbtn.Text = "print table";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.Crimson;
            this.findbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbtn.ForeColor = System.Drawing.Color.White;
            this.findbtn.Location = new System.Drawing.Point(234, 36);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(75, 28);
            this.findbtn.TabIndex = 6;
            this.findbtn.Text = "Find";
            this.findbtn.UseVisualStyleBackColor = false;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(591, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(346, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter by";
            // 
            // searchall
            // 
            this.searchall.BackColor = System.Drawing.SystemColors.Menu;
            this.searchall.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchall.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchall.Location = new System.Drawing.Point(128, 38);
            this.searchall.Name = "searchall";
            this.searchall.Size = new System.Drawing.Size(100, 25);
            this.searchall.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by all";
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status.BackColor = System.Drawing.SystemColors.Menu;
            this.status.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.DarkGreen;
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(648, 39);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(88, 25);
            this.status.TabIndex = 1;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            // 
            // filterby
            // 
            this.filterby.BackColor = System.Drawing.SystemColors.MenuBar;
            this.filterby.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterby.ForeColor = System.Drawing.Color.DarkGreen;
            this.filterby.FormattingEnabled = true;
            this.filterby.Location = new System.Drawing.Point(415, 36);
            this.filterby.Name = "filterby";
            this.filterby.Size = new System.Drawing.Size(149, 25);
            this.filterby.TabIndex = 0;
            this.filterby.SelectedIndexChanged += new System.EventHandler(this.filterby_SelectedIndexChanged);
            // 
            // productstable
            // 
            this.productstable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productstable.BackgroundColor = System.Drawing.Color.White;
            this.productstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productstable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productstable.Location = new System.Drawing.Point(7, 195);
            this.productstable.Name = "productstable";
            this.productstable.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productstable.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productstable.Size = new System.Drawing.Size(907, 308);
            this.productstable.TabIndex = 2;
            this.productstable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productstable_CellContentClick);
            // 
            // printProducts
            // 
            this.printProducts.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printProducts_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.MediumBlue;
            this.refresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(169, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(127, 33);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh Table";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // viewp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.productstable);
            this.Controls.Add(this.operstock);
            this.Controls.Add(this.label1);
            this.Name = "viewp";
            this.Size = new System.Drawing.Size(929, 520);
            this.Load += new System.EventHandler(this.viewp_Load);
            this.operstock.ResumeLayout(false);
            this.operstock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productstable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox operstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox filterby;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView productstable;
        private System.Windows.Forms.Button findbtn;
        private System.Drawing.Printing.PrintDocument printProducts;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button refresh;
    }
}
