namespace BBQ_SHOP
{
    partial class owner_menu
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
            this.emp_button = new System.Windows.Forms.Button();
            this.product_button = new System.Windows.Forms.Button();
            this.emp_details_button = new System.Windows.Forms.Button();
            this.sales_details_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emp_button
            // 
            this.emp_button.Location = new System.Drawing.Point(132, 36);
            this.emp_button.Name = "emp_button";
            this.emp_button.Size = new System.Drawing.Size(174, 37);
            this.emp_button.TabIndex = 0;
            this.emp_button.Text = "EMPLOYEE";
            this.emp_button.UseVisualStyleBackColor = true;
            this.emp_button.Click += new System.EventHandler(this.emp_button_Click);
            // 
            // product_button
            // 
            this.product_button.Location = new System.Drawing.Point(132, 106);
            this.product_button.Name = "product_button";
            this.product_button.Size = new System.Drawing.Size(174, 37);
            this.product_button.TabIndex = 1;
            this.product_button.Text = " PRODUCT";
            this.product_button.UseVisualStyleBackColor = true;
            this.product_button.Click += new System.EventHandler(this.product_button_Click);
            // 
            // emp_details_button
            // 
            this.emp_details_button.Location = new System.Drawing.Point(132, 244);
            this.emp_details_button.Name = "emp_details_button";
            this.emp_details_button.Size = new System.Drawing.Size(174, 37);
            this.emp_details_button.TabIndex = 3;
            this.emp_details_button.Text = "LOGOUT";
            this.emp_details_button.UseVisualStyleBackColor = true;
            this.emp_details_button.Click += new System.EventHandler(this.emp_details_button_Click);
            // 
            // sales_details_button
            // 
            this.sales_details_button.Location = new System.Drawing.Point(132, 173);
            this.sales_details_button.Name = "sales_details_button";
            this.sales_details_button.Size = new System.Drawing.Size(174, 37);
            this.sales_details_button.TabIndex = 4;
            this.sales_details_button.Text = "PROFIT/LOSS";
            this.sales_details_button.UseVisualStyleBackColor = true;
            this.sales_details_button.Click += new System.EventHandler(this.sales_details_button_Click);
            // 
            // owner_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 397);
            this.Controls.Add(this.sales_details_button);
            this.Controls.Add(this.emp_details_button);
            this.Controls.Add(this.product_button);
            this.Controls.Add(this.emp_button);
            this.Name = "owner_menu";
            this.Text = "a";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emp_button;
        private System.Windows.Forms.Button product_button;
        private System.Windows.Forms.Button emp_details_button;
        private System.Windows.Forms.Button sales_details_button;
    }
}