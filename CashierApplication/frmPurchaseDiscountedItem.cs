using ItemNameSpace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        DiscountedItem di;
        frmLoginAccount fLA = new frmLoginAccount();
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        //count the number of dots
        public bool countDot(string text) 
        {
            int count = 0;
            bool a = true;
            for (int i=0;i<text.Length;i++) 
            {
                if (text[i] == '.')
                {
                    count++;
                }
            }
            if (count > 1) 
            {
                a = false;
            }
            return a;
        }

        private void ComputeBTN_Click(object sender, EventArgs e)
        {
            //check if input are numbers or decimal numbers
            Regex priceReg = new Regex("(^\\d+\\.?\\d$)|(\\.?\\d+$)");
            Regex dq = new Regex("^[0-9]+$");

            if (!ItemTXT.Text.Equals("") && !PriceTXT.Text.Equals("") && !QuantityTXT.Text.Equals("") && !DiscountTXT.Text.Equals(""))
            {

                if (countDot(PriceTXT.Text) && priceReg.IsMatch(PriceTXT.Text))
                {
                    if (dq.IsMatch(DiscountTXT.Text) && dq.IsMatch(QuantityTXT.Text))
                    {
                        double price = Convert.ToDouble(PriceTXT.Text);
                        int quantity = Convert.ToInt32(QuantityTXT.Text);
                        double discount = Convert.ToDouble(DiscountTXT.Text);
                        di = new DiscountedItem(ItemTXT.Text, price, quantity, discount);
                        TotalAmountLBL.Text = di.getTotalPrice().ToString();
                        ItemTXT.Enabled = false;
                        PriceTXT.Enabled = false;
                        QuantityTXT.Enabled = false;
                        DiscountTXT.Enabled = false;
                        PaymentTXT.Enabled = true;
                        SubmitBTN.Enabled = true;
                        if (ItemTXT.Enabled == false) 
                        {
                            ComputeBTN.Visible = false;
                            EditBTN.Visible = true;
                        }
                    }
                    else 
                    {
                        if (!dq.IsMatch(DiscountTXT.Text) && dq.IsMatch(QuantityTXT.Text))
                        {
                            MessageBox.Show("Discount cannot recognize!");
                        }
                        else if (dq.IsMatch(DiscountTXT.Text) && !dq.IsMatch(QuantityTXT.Text))
                        {
                            MessageBox.Show("Quantity cannot recognize!");
                        }
                        else 
                        {
                            MessageBox.Show("Discount and Quantity cannot recognize!");
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Price Cannot Recognize!");
                }
            }
            else 
            {
                MessageBox.Show("Please fill 'Item','Price','Quantity','Discount'");
            }
        }

        //edit inputs if there are errors
        private void EditBTN_Click(object sender, EventArgs e)
        {
            SubmitBTN.Enabled = false;
            PaymentTXT.Enabled = false;
            PaymentTXT.Clear();
            ClearBTN.Visible = false;
            ChangeLBL.Text = "";
            ItemTXT.Enabled = true;
            PriceTXT.Enabled = true;
            QuantityTXT.Enabled = true;
            DiscountTXT.Enabled = true;
            EditBTN.Visible = false;
            ComputeBTN.Visible = true;
        }

        //pay
        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            Regex payReg = new Regex("(^\\d+\\.?\\d$)|(\\.?\\d+$)");
            if (!PaymentTXT.Text.Equals(""))
            {
                if (payReg.IsMatch(PaymentTXT.Text) && countDot(PaymentTXT.Text))
                {
                    double paymentAmount = Convert.ToDouble(PaymentTXT.Text);
                    di.setPayment(paymentAmount);
                    ChangeLBL.Text = di.getChange().ToString("0.00");
                    ClearBTN.Visible = true;
                }
                else
                {
                    MessageBox.Show("Payment cannot recognize!");
                }
            }
            else 
            {
                MessageBox.Show("Input Amount!");
            }
        }

        //reset
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            PaymentTXT.Clear();
            PaymentTXT.Enabled = false;
            SubmitBTN.Enabled = false;
            ChangeLBL.Text = "";
            ClearBTN.Visible = false;

            ItemTXT.Clear();
            PriceTXT.Clear();
            DiscountTXT.Clear();
            QuantityTXT.Clear();
            ItemTXT.Enabled = true;
            PriceTXT.Enabled = true;
            DiscountTXT.Enabled = true;
            QuantityTXT.Enabled = true;
            ComputeBTN.Visible = true;
            EditBTN.Visible = false;
            TotalAmountLBL.Text = "";

        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }

        //logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
                fLA.Show();
            }
            
        }

        //exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit Application", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

namespace ItemNameSpace
{
    //parent class
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);

    }

    //subclass
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount/100;
            this.discounted_price = (this.item_price * this.item_quantity) * this.item_discount;
        }

        public override double getTotalPrice()
        {
            this.total_price = (this.item_price * this.item_quantity) - this.discounted_price;
            return this.total_price;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            this.change = this.payment_amount - this.total_price;
            return this.change;
        }
    }
}
