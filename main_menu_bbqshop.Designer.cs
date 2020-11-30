namespace BBQ_SHOP
{
    partial class main_menu_bbqshop
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
            this.starter_button = new System.Windows.Forms.Button();
            this.maincourse_button = new System.Windows.Forms.Button();
            this.deserts_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // starter_button
            // 
            this.starter_button.Location = new System.Drawing.Point(113, 66);
            this.starter_button.Name = "starter_button";
            this.starter_button.Size = new System.Drawing.Size(125, 61);
            this.starter_button.TabIndex = 0;
            this.starter_button.Text = "ORDER";
            this.starter_button.UseVisualStyleBackColor = true;
            this.starter_button.Click += new System.EventHandler(this.starter_button_Click);
            // 
            // maincourse_button
            // 
            this.maincourse_button.Location = new System.Drawing.Point(113, 171);
            this.maincourse_button.Name = "maincourse_button";
            this.maincourse_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maincourse_button.Size = new System.Drawing.Size(125, 61);
            this.maincourse_button.TabIndex = 1;
            this.maincourse_button.Text = "VIEW ORDER DETAILS";
            this.maincourse_button.UseVisualStyleBackColor = true;
            this.maincourse_button.Click += new System.EventHandler(this.maincourse_button_Click);
            // 
            // deserts_button
            // 
            this.deserts_button.Location = new System.Drawing.Point(113, 273);
            this.deserts_button.Name = "deserts_button";
            this.deserts_button.Size = new System.Drawing.Size(125, 61);
            this.deserts_button.TabIndex = 2;
            this.deserts_button.Text = "VIEW CART";
            this.deserts_button.UseVisualStyleBackColor = true;
            this.deserts_button.Click += new System.EventHandler(this.deserts_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "WASTE FOOD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main_menu_bbqshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deserts_button);
            this.Controls.Add(this.maincourse_button);
            this.Controls.Add(this.starter_button);
            this.Name = "main_menu_bbqshop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button starter_button;
        private System.Windows.Forms.Button maincourse_button;
        private System.Windows.Forms.Button deserts_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}