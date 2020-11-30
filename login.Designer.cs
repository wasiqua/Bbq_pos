namespace BBQ_SHOP
{
    partial class login_label
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
            this.login_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(91, 178);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(89, 29);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(43, 65);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(80, 13);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "USER NAME";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(43, 124);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "PASSWORD";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(138, 65);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(100, 20);
            this.name_text.TabIndex = 3;
            this.name_text.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(138, 121);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(100, 20);
            this.pass_text.TabIndex = 4;
            this.pass_text.TextChanged += new System.EventHandler(this.pass_text_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OWNER",
            "USER"});
            this.comboBox1.Location = new System.Drawing.Point(138, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 304);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.login_button);
            this.Name = "login_label";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_label_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}