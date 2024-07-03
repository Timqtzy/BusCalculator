using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusCalc
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }


        public void info(double quantity, double change, double Fare, double payments, string destination, double discountedPrice, double discount, string category, int transactionNumber)
        {
            Transactiontxt.Text = "Transaction #: " + transactionNumber.ToString();
            Quantitytxt.Text = "Quantity: " + quantity.ToString();
            Faretxt.Text = "Fare: " + Fare.ToString();
            Destinationtxt.Text = "Destination: " + destination;
            totalFaretxt.Text = "Total Fare: " + discountedPrice.ToString();
            Changetxt.Text = "Change: " + change.ToString();
            DiscountedPrice.Text = "Discount: " + discount.ToString() + "%";
            Categorytxt.Text = "Category: " + category;
            Paymenttxt.Text = "Payment: " + payments.ToString();
        }

       

       

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
