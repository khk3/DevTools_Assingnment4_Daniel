using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name:Daniel Oliveira
        * Date:11/11/2022
        * This program books a trip and calculates the price */

        /*Name: ResetTrip
        Sent: none
        Returned:none
        Performs a reset. The reset will hide grpTripInformation, select radCuba,blank txtPeople
        and txtPrice, select radCreditCard put the cursor on txtPeople*/
        private void ResetTrip()
        {
            grpTripInformation.Hide();
            radCuba.Checked = true;
            txtPeople.Text = "";
            lblPriceOutput.Text = "";
            radCreditCard.Checked = true;
            txtPeople.Focus();
        }

        /*Name: SetFlight
        Sent: none
        Returned:none
        If Florida is selected, there isn't flights but others locations include the flight*/
        private void SetFlight()
        {
            if(radCuba.Checked)
            {
                chkFlightIncluded.Checked = true;
            }
            if(radFlorida.Checked)
            {
                chkFlightIncluded.Checked = false;
            }
            if(radMexico.Checked)
            {
                chkFlightIncluded.Checked = true;
            }
        }

        /*Name: DisplayMsg
        Sent: 2 strings
        Returned:none
        Displays a messagebox*/
        private void DisplayMsg(int msg)
        {
            switch (msg)
            {
                case 1:
                    grpBook.Enabled = true;
                    MessageBox.Show("People must be a whole number", "Input Error");
                    ResetTrip();
                    break;
                case 2:
                    grpBook.Enabled = true;
                    MessageBox.Show("People must be between 1-10", "Input Error");
                    ResetTrip();
                    break;
                case 3:
                    MessageBox.Show("Special when booking single or triple./n"
                        +"BOGO Special- Call 555-1212 to receive another person free!","Limit Time Offer");
                    break;
                case 4:
                    MessageBox.Show("Trip booked and paid.\n" +
                        "Price: " + lblPriceOutput.Text, "Confirmation Email Sent");
                    break;
            }
            
        }
        //Calls ResetTrip function
        private void btnReset_Click(object sender, EventArgs e)
        {
            
            ResetTrip();
        }

        //Calls SetFlight function(if radCuba is cheked,radFlightIncluded is checked as well)
        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }

        //Calls SetFlight function(if radFlorida is cheked,radFlightIncluded isn't checked)
        private void radFlorida_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }

        //Calls SetFlight function(if radMexico is cheked,radFlightIncluded is checked as well)
        private void radMexico_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }

        //Data validation and calculates the price
        private void btnBook_Click(object sender, EventArgs e)
        {
            //Set the variables
            bool validPeople;
            int people;
            double price = 0;
            string location=null, flight=null, cashDiscount = null;
            validPeople = int.TryParse(txtPeople.Text, out people);

            //The user won't interact along with grpBook
            grpBook.Enabled = false;

            //Validating if people is int
            if (validPeople == false)
            {
                DisplayMsg(1);
            }

            //Validating the range
            else if (people < 1 || people > 10)
            {
                DisplayMsg(2);
            }

            //Cheking if people is equal to 1 or 3 to display a promotional message
            else
            {
                switch (people)
                {
                    case 1:
                        DisplayMsg(3);
                        break;
                    case 3:
                        DisplayMsg(3);
                        break;
                }

                //Calculate the price to Cuba with cash discount
                if (radCuba.Checked && radCash.Checked)
                {
                    price = people * 2150.50;
                    location = "Cuba\n";
                    flight = "Flight included";
                    price = price - (price * 0.1);
                    cashDiscount = "\nCash discount Applied";
                }

                //Calculate the price to Cuba without cash discount
                if (radCuba.Checked && radCreditCard.Checked)
                {
                    price = people * 2150.50;
                    location = "Cuba\n";
                    flight = "Flight included";
                    cashDiscount = null;
                }

                //Calculate the price to Florida with cash discount
                if (radFlorida.Checked && radCash.Checked)
                {
                    price = people * 2150.50;
                    location = "Florida";
                    flight = null;
                    price = price - (price * 0.1);
                    cashDiscount = "\nCash discount Applied";
                }

                //Calculate the price to Florida without cash discount
                if (radFlorida.Checked && radCreditCard.Checked)
                {
                    price = people * 2150.50;
                    location = "Florida";
                    flight = null;
                    cashDiscount = null;
                }

                //Calculate the price to Mexico with cash discount
                if (radMexico.Checked && radCash.Checked)
                {
                    price = people * 2300.79;
                    location = "Mexico\n";
                    flight = "Flight included";
                    price = price - (price * 0.1);
                    cashDiscount = "\nCash discount Applied";
                }

                //Calculate the price to Mexico without cash discount
                if (radMexico.Checked && radCreditCard.Checked)
                {
                    price = people * 2300.79;
                    location = "Mexico\n";
                    flight = "Flight included";
                    cashDiscount = null;
                }

                //Display the data on laybels
                lblPriceOutput.Text = price.ToString("C");
                lblDisplay.Text = "";
                lblDisplay.Text = "Bokked by Daniel \n \n" + "People: " + people.ToString("D2") +
                "\n" + "Location: " + location + flight + cashDiscount + "\n" + "Price: "
                + price.ToString("C");
                grpTripInformation.Visible = true;
            }
            
            
        }
        //Confirm the operation and display a confirmation message
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DisplayMsg(4);
            grpBook.Enabled = true;
            ResetTrip();
        }

        //Hide the lblDisplay
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTrip();
        }
    }
}