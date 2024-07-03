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
   

    public partial class MainForm : Form
    {
        Fare fare = new Fare();
        Discount discount = new Discount();

        double FarePrice = 0;
        int quanti = 0;
        double discountedFare = 0;
        double Payments = 0;
        double Change = 0;
        double FareDestination = 0;
        string destination = "";
        double discountCategory = 0;
        string categoryDisplay = "";
        int transactionNumber = 0;
       
        

        void BackCol()
        {
            
            StudentBtn.BackColor = Color.FromArgb(73, 113, 255);
            CitizenBtn.BackColor = Color.FromArgb(73, 113, 255);
            SeniorBtn.BackColor = Color.FromArgb(73, 113, 255);
            PWDBtn.BackColor = Color.FromArgb(73, 113, 255);
        }
        double DiscountCalc(double disc, int quan)
        {
            double discount = (FarePrice/quan) * disc;
            return quanti * ((FarePrice/quanti) - discount);
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReceiptDisplay.Enabled = false;
        }

       

        private void AvidaBtn_Click(object sender, EventArgs e)
        {
            destination = "Avida";
            FareDestination = fare.Avida;
            FareTxt.Text = "Fare: " + fare.Avida.ToString();

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            int quant = 0;

            Int32.TryParse(Quantity.Text, out quant);
            quanti = quant;
            FarePrice = FareDestination * quanti;
            FareTxt.Text = "Fare: " + FarePrice.ToString();
        }

        private void PWDBtn_Click(object sender, EventArgs e)
        {
            categoryDisplay = "PWD";
            discountCategory = 10;
            discountedFare = DiscountCalc(discount.PWDDiscount,quanti);
            DiscountedTxt.Text = "Discounted Fare: " + discountedFare.ToString();
            Discounttxt.Text = "Discount: " + discountCategory + "%";
            BackCol();
            PWDBtn.BackColor = Color.FromArgb(125, 114, 255);
           
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            categoryDisplay = "Student";
            discountCategory = 5;
            discountedFare = DiscountCalc(discount.StudentsDiscount,quanti);
            DiscountedTxt.Text = "Discounted Fare: " + discountedFare.ToString();
            Discounttxt.Text = "Discount: " + discountCategory + "%";
            BackCol();
            StudentBtn.BackColor = Color.FromArgb(125, 114, 255);
        }

        private void CitizenBtn_Click(object sender, EventArgs e)
        {
            categoryDisplay = "Citizen";
            discountCategory = 0;
            discountedFare = DiscountCalc(discount.CitizenDiscount, quanti);
            DiscountedTxt.Text = "Discounted Fare: " + discountedFare.ToString();
            Discounttxt.Text = "Discount: " + discountCategory + "%";
            BackCol();
            CitizenBtn.BackColor = Color.FromArgb(125, 114, 255);
        }

        private void SeniorBtn_Click(object sender, EventArgs e)
        {
            categoryDisplay = "Senior";
            discountCategory = 10;
            discountedFare = DiscountCalc(discount.SeniorDiscount,quanti);
            DiscountedTxt.Text = "Discounted Fare: " + discountedFare.ToString();
            Discounttxt.Text = "Discount: " + discountCategory + "%";
            BackCol();
            SeniorBtn.BackColor = Color.FromArgb(125, 114, 255);
        }

        private void AmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ReceiptDisplay_Click(object sender, EventArgs e)
        {
            transactionNumber+=1;
            Receipt receiptForm = new Receipt();
            receiptForm.Show();
            receiptForm.info( quanti, Change, FarePrice, Payments, destination, discountedFare, discountCategory, categoryDisplay, transactionNumber);
            ReceiptDisplay.Enabled = false;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            discountedFare = 0;
            FarePrice = 0;
            quanti = 0;
            Payments = 0;
            Change = 0;
            discountCategory = 0;
           

            FareTxt.Text = "Fare: " + FarePrice;
            DiscountedTxt.Text = "Discounted Fare: ";
            ChangeTxt.Text = "Change: " + Change;
            Discounttxt.Text = "Discount: ";
            AmountTxtBox.Text = "";
            Quantity.Text = "";

            BackCol();
        }

        private void DarkModeBtn_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void DelRoBtn_Click(object sender, EventArgs e)
        {
            destination = "Del Rosario";
            FareDestination = fare.DelRosario;
            FareTxt.Text = "Fare: " + fare.DelRosario.ToString();
        }

        private void DoloresBtn_Click(object sender, EventArgs e)
        {
            destination = "Dolores";
            FareDestination = fare.Dolores;
            FareTxt.Text = "Fare: " + fare.Dolores.ToString();
        }

        private void IntersectionBtn_Click(object sender, EventArgs e)
        {
            destination = "Intersection";
            FareDestination = fare.Intersection;
            FareTxt.Text = "Fare: " + fare.Intersection.ToString();
        }

        private void JBLBtn_Click(object sender, EventArgs e)
        {
            destination = "JBL";
            FareDestination = fare.JBL;
            FareTxt.Text = "Fare: " + fare.JBL.ToString();
        }

        private void MaimpisBtn_Click(object sender, EventArgs e)
        {
            destination = "Maimpis";
            FareDestination = fare.Maimpis;
            FareTxt.Text = "Fare: " + fare.Maimpis.ToString();
        }

        private void PalengkeBtn_Click(object sender, EventArgs e)
        {
            destination = "Palengke";
            FareDestination = fare.Palengke;
            FareTxt.Text = "Fare: " + fare.Palengke.ToString();
        }

        private void QuebiauanBtn_Click(object sender, EventArgs e)
        {
            destination = "Quebiauan";
            FareDestination = fare.Quebiauan;
            FareTxt.Text = "Fare: " + fare.Quebiauan.ToString();
        }

        private void SakopBtn_Click(object sender, EventArgs e)
        {
            destination = "Sakop";
            FareDestination = fare.Sakop;
            FareTxt.Text = "Fare: " + fare.Sakop.ToString();
        }

        private void SanAgustineBtn_Click(object sender, EventArgs e)
        {
            destination = "San Agustine";
            FareDestination = fare.SanAgustine;
            FareTxt.Text = "Fare: " + fare.SanAgustine.ToString();
        }

        private void SanIsidroBtn_Click(object sender, EventArgs e)
        {
            destination = "San Isidro";
            FareDestination = fare.SanIsidro;
            FareTxt.Text = "Fare: " + fare.SanIsidro.ToString();
        }

        private void SanFernandoBtn_Click(object sender, EventArgs e)
        {
            destination = "San Fernando";
            FareDestination = fare.SanFernando;
            FareTxt.Text = "Fare: " + fare.SanFernando.ToString();
        }

        private void SanMiguelBtn_Click(object sender, EventArgs e)
        {
            destination = "San Miguel";
            FareDestination = fare.SanMiguel;
            FareTxt.Text = "Fare: " + fare.SanMiguel.ToString();
        }

        private void SMTerminalBtn_Click(object sender, EventArgs e)
        {
            destination = "SM Terminal";
            FareDestination = fare.SMIntersection;
            FareTxt.Text = "Fare: " + fare.SMIntersection.ToString();
        }

        private void WalterBtn_Click(object sender, EventArgs e)
        {
            destination = "Walter";
            FareDestination = fare.Walter;
            FareTxt.Text = "Fare: " + fare.Walter.ToString();
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            double num = 0;
            Double.TryParse(AmountTxtBox.Text, out num);
            Payments = num;
            Change = Payments - discountedFare;
            if (num >= discountedFare)
            {
                ChangeTxt.Text = "Change: " + Change;
                ReceiptDisplay.Enabled = true;
            }
            else
            {
                ChangeTxt.Text = "Change: " + "insufficient money!";
            }
        }
    }
}
