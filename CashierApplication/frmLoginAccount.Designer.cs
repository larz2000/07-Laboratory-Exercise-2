namespace CashierApplication
{
    partial class frmLoginAccount
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
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTXT = new System.Windows.Forms.TextBox();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Location = new System.Drawing.Point(12, 126);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(194, 32);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTXT.Location = new System.Drawing.Point(12, 32);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.Size = new System.Drawing.Size(194, 26);
            this.UsernameTXT.TabIndex = 2;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTXT.Location = new System.Drawing.Point(12, 85);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.PasswordChar = '*';
            this.PasswordTXT.Size = new System.Drawing.Size(194, 26);
            this.PasswordTXT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // frmLoginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 168);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLoginAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.frmLoginAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTXT;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Label label2;
    }
}