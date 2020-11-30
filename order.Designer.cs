namespace BBQ_SHOP
{
    partial class order
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Details_Box = new System.Windows.Forms.TextBox();
            this.Price_Box = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.QTY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QTY)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(25, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Details";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD TO CART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "RETURN TO MAIN MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(25, 54);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.ReadOnly = true;
            this.Name_Box.Size = new System.Drawing.Size(155, 20);
            this.Name_Box.TabIndex = 11;
            // 
            // Details_Box
            // 
            this.Details_Box.Location = new System.Drawing.Point(25, 97);
            this.Details_Box.Name = "Details_Box";
            this.Details_Box.ReadOnly = true;
            this.Details_Box.Size = new System.Drawing.Size(264, 20);
            this.Details_Box.TabIndex = 11;
            // 
            // Price_Box
            // 
            this.Price_Box.Location = new System.Drawing.Point(221, 54);
            this.Price_Box.Name = "Price_Box";
            this.Price_Box.ReadOnly = true;
            this.Price_Box.Size = new System.Drawing.Size(144, 20);
            this.Price_Box.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "VIEW CART";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(3, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.ReadOnly = true;
            this.ID_Box.Size = new System.Drawing.Size(155, 20);
            this.ID_Box.TabIndex = 11;
            this.ID_Box.Visible = false;
            // 
            // QTY
            // 
            this.QTY.Location = new System.Drawing.Point(324, 97);
            this.QTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(83, 20);
            this.QTY.TabIndex = 13;
            this.QTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QTY.Visible = false;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 383);
            this.Controls.Add(this.QTY);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Price_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.Details_Box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Details_Box;
        private System.Windows.Forms.TextBox Price_Box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.NumericUpDown QTY;
    }
}