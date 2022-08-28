namespace InventoryStock.controllers.usercontrols
{
    partial class customer
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
            this.cutome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cutome
            // 
            this.cutome.Location = new System.Drawing.Point(341, 78);
            this.cutome.Name = "cutome";
            this.cutome.Size = new System.Drawing.Size(75, 300);
            this.cutome.TabIndex = 0;
            this.cutome.Text = "cuatomer";
            this.cutome.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cutome);
            this.Name = "customer";
            this.Size = new System.Drawing.Size(700, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cutome;
    }
}
