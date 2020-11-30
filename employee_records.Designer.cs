namespace BBQ_SHOP
{
    partial class search_button
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user_id_label = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.salary_label = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.sal_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_password,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(28, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "ID";
            this.user_id.Name = "user_id";
            // 
            // user_name
            // 
            this.user_name.HeaderText = "NAME";
            this.user_name.Name = "user_name";
            // 
            // user_password
            // 
            this.user_password.HeaderText = "PASSWORD";
            this.user_password.Name = "user_password";
            // 
            // salary
            // 
            this.salary.HeaderText = "SALARY";
            this.salary.Name = "salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(510, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "RETURN TO MAIN MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_id_label
            // 
            this.user_id_label.AutoSize = true;
            this.user_id_label.Location = new System.Drawing.Point(25, 31);
            this.user_id_label.Name = "user_id_label";
            this.user_id_label.Size = new System.Drawing.Size(18, 13);
            this.user_id_label.TabIndex = 6;
            this.user_id_label.Text = "ID";
            this.user_id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(126, 24);
            this.id_text.Name = "id_text";
            this.id_text.ReadOnly = true;
            this.id_text.Size = new System.Drawing.Size(100, 20);
            this.id_text.TabIndex = 7;
            this.id_text.TextChanged += new System.EventHandler(this.id_text_TextChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(25, 70);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 8;
            this.name_label.Text = "NAME";
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Location = new System.Drawing.Point(25, 144);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(49, 13);
            this.salary_label.TabIndex = 9;
            this.salary_label.Text = "SALARY";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(126, 63);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(100, 20);
            this.name_text.TabIndex = 10;
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(126, 101);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(100, 20);
            this.pass_text.TabIndex = 11;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(25, 108);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(70, 13);
            this.pass_label.TabIndex = 12;
            this.pass_label.Text = "PASSWORD";
            // 
            // sal_text
            // 
            this.sal_text.Location = new System.Drawing.Point(126, 137);
            this.sal_text.Name = "sal_text";
            this.sal_text.Size = new System.Drawing.Size(100, 20);
            this.sal_text.TabIndex = 13;
            // 
            // search_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 466);
            this.Controls.Add(this.sal_text);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.user_id_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "search_button";
            this.Text = "EMPLOYEE ";
            this.Load += new System.EventHandler(this.employee_records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label user_id_label;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox sal_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}