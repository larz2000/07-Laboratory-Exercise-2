namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscountTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTXT = new System.Windows.Forms.TextBox();
            this.QuantityTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComputeBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmountLBL = new System.Windows.Forms.Label();
            this.PaymentTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ChangeLBL = new System.Windows.Forms.Label();
            this.EditBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // ItemTXT
            // 
            this.ItemTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTXT.Location = new System.Drawing.Point(16, 51);
            this.ItemTXT.Name = "ItemTXT";
            this.ItemTXT.Size = new System.Drawing.Size(215, 26);
            this.ItemTXT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount (%):";
            // 
            // DiscountTXT
            // 
            this.DiscountTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTXT.Location = new System.Drawing.Point(250, 51);
            this.DiscountTXT.Name = "DiscountTXT";
            this.DiscountTXT.Size = new System.Drawing.Size(144, 26);
            this.DiscountTXT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // PriceTXT
            // 
            this.PriceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTXT.Location = new System.Drawing.Point(70, 87);
            this.PriceTXT.Name = "PriceTXT";
            this.PriceTXT.Size = new System.Drawing.Size(161, 26);
            this.PriceTXT.TabIndex = 5;
            // 
            // QuantityTXT
            // 
            this.QuantityTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTXT.Location = new System.Drawing.Point(320, 87);
            this.QuantityTXT.Name = "QuantityTXT";
            this.QuantityTXT.Size = new System.Drawing.Size(74, 26);
            this.QuantityTXT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // ComputeBTN
            // 
            this.ComputeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeBTN.Location = new System.Drawing.Point(156, 119);
            this.ComputeBTN.Name = "ComputeBTN";
            this.ComputeBTN.Size = new System.Drawing.Size(104, 28);
            this.ComputeBTN.TabIndex = 8;
            this.ComputeBTN.Text = "Compute";
            this.ComputeBTN.UseVisualStyleBackColor = true;
            this.ComputeBTN.Click += new System.EventHandler(this.ComputeBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount:";
            // 
            // TotalAmountLBL
            // 
            this.TotalAmountLBL.AutoSize = true;
            this.TotalAmountLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLBL.Location = new System.Drawing.Point(180, 175);
            this.TotalAmountLBL.Name = "TotalAmountLBL";
            this.TotalAmountLBL.Size = new System.Drawing.Size(0, 20);
            this.TotalAmountLBL.TabIndex = 10;
            // 
            // PaymentTXT
            // 
            this.PaymentTXT.Enabled = false;
            this.PaymentTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTXT.Location = new System.Drawing.Point(164, 222);
            this.PaymentTXT.Name = "PaymentTXT";
            this.PaymentTXT.Size = new System.Drawing.Size(114, 26);
            this.PaymentTXT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment Receive:";
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Enabled = false;
            this.SubmitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBTN.Location = new System.Drawing.Point(284, 221);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(88, 28);
            this.SubmitBTN.TabIndex = 13;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Change:";
            // 
            // ChangeLBL
            // 
            this.ChangeLBL.AutoSize = true;
            this.ChangeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLBL.Location = new System.Drawing.Point(180, 265);
            this.ChangeLBL.Name = "ChangeLBL";
            this.ChangeLBL.Size = new System.Drawing.Size(0, 20);
            this.ChangeLBL.TabIndex = 15;
            // 
            // EditBTN
            // 
            this.EditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBTN.Location = new System.Drawing.Point(156, 119);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(104, 28);
            this.EditBTN.TabIndex = 16;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Visible = false;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBTN.Location = new System.Drawing.Point(284, 257);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(88, 28);
            this.ClearBTN.TabIndex = 17;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Visible = false;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 25);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.Controls.Add(this.ComputeBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.ChangeLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.PaymentTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalAmountLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiscountTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPurchaseDiscountedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Discounted Item";
            this.Load += new System.EventHandler(this.frmPurchaseDiscountedItem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiscountTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTXT;
        private System.Windows.Forms.TextBox QuantityTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ComputeBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalAmountLBL;
        private System.Windows.Forms.TextBox PaymentTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ChangeLBL;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

