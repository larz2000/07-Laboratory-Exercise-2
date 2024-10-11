using UserAccountNamespace;
using CashierApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string[] AccountName = { "Larry Sarzona", "Larz Sarz", "Lari Sarzo" };//Account Fullname
            string[] Department = { "Department Store", "Services", "Supermarket" };//Account Department

            Cashier c = new Cashier("","",UsernameTXT.Text,PasswordTXT.Text);
            frmPurchaseDiscountedItem fPD = new frmPurchaseDiscountedItem();//create object for PurchaseDiscountedItem

            if (!UsernameTXT.Text.Equals("") && !PasswordTXT.Text.Equals(""))
            {
                if (c.validateLogin(UsernameTXT.Text, PasswordTXT.Text))
                {
                    //update the information
                    c = new Cashier(AccountName[c.getIndex()], Department[c.getIndex()], UsernameTXT.Text, PasswordTXT.Text);

                    MessageBox.Show("Welcome " + c.getFullName() + " of " + c.getDepartment());
                    UsernameTXT.Clear();
                    PasswordTXT.Clear();
                    fPD.Show();//show the PurchaseDiscountedItem form
                    this.Hide();//hide this form
                }
            }
            else 
            {
                if (UsernameTXT.Text.Equals("") && !PasswordTXT.Text.Equals(""))
                {
                    MessageBox.Show("Please Enter Username!");
                }
                else if (!UsernameTXT.Text.Equals("") && PasswordTXT.Text.Equals(""))
                {
                    MessageBox.Show("Please Enter Password!");
                }
                else 
                {
                    MessageBox.Show("Please Enter Username and Password!");
                }
            }
        }
    }
}

namespace UserAccountNamespace
{
    public abstract class UserAccount 
    {
        private string full_name;
        protected string user_name;
        protected string user_password;
        
        public UserAccount(string name, string uName, string password) 
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName() 
        {
            return this.full_name;
        }
    }

    public class Cashier:UserAccount
    {
        private string department;
        private int index;

        public Cashier(string name, string department, string uName, string password):base(name, uName, password) 
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            bool validate = false;
            
            string[] Username = { "cashierLarry", "cashierLarz", "cashierLari" };//account username
            string[] Password = { "1234567890", "0987654321", "1234509876" };// account password

            if (Array.Exists(Username, element => element == uName))//check if the username exists
            {
                index = Array.IndexOf(Username, uName);// get the index of username, will be the index of password
                if (password.Equals(Password[index]))
                {
                    validate = true;
                }
                else 
                {
                    MessageBox.Show("Incorrect Password!");
                }
            }
            else 
            {
                MessageBox.Show("Account cannot found!");
            }

            return validate;
        }

        public string getDepartment() 
        {
            return department;
        }

        //get the index
        public int getIndex() 
        {
            return index;
        }
    }
}
