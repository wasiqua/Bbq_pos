﻿namespace BBQ_SHOP
{
    partial class owner_button
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
            this.button1 = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "OWNER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(41, 154);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(196, 40);
            this.user_button.TabIndex = 1;
            this.user_button.Text = "USER";
            this.user_button.UseVisualStyleBackColor = true;
            // 
            // owner_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 290);
            this.Controls.Add(this.user_button);
            this.Controls.Add(this.button1);
            this.Name = "owner_button";
            this.Text = "identity";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button user_button;
    }
}