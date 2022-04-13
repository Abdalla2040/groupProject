using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marys_Auto
{
    public partial class mainUserInputForm : Form
    {
        public mainUserInputForm()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerFirstName = firstNameBox.Text;
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerLastName = lastNameBox.Text;
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerCity = cityBox.Text;
        }

        private void stateBox_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerState = stateBox.Text;
        }

        private void streetAdressBox_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerStreetAddress = streetAdressBox.Text;
        }

        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerPhoneNumber = phoneNumberBox.Text;

        }
        Customer cus1 = new Customer();
        
        private void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                cus1.CustomersList.Add(customer);
                customer.CustomersList.ForEach(x => MessageBox.Show($"{x.CustomerFirstName}, {x.CustomerLastName}, {x.CustomerPhoneNumber}, {x.CustomerStreetAddress}"));
                //Customer Info Null Check
                if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(cityBox.Text) || String.IsNullOrEmpty(stateBox.Text) || String.IsNullOrEmpty(streetAdressBox.Text) || String.IsNullOrEmpty(phoneNumberBox.Text))
                {
                    MessageBox.Show("One or more of the boxes were left blank in the Customer Info section. Please fill out every box.","Customer Info Null");
                }
                //int num;
                //int.TryParse(phoneNumberBox.Text, out num);
                //Phone Number Check 
                
            foreach(char c in firstNameBox.Text)
                if (Char.IsDigit(c))
                {

                    if (phoneNumberBox.Text.Length == 10)
                    {
                        //Vehicle Info Null Check
                        if (String.IsNullOrEmpty(makeBox.Text) || String.IsNullOrEmpty(modelBox.Text) || String.IsNullOrEmpty(trimBox.Text) || String.IsNullOrEmpty(trimBox.Text) || String.IsNullOrEmpty(vinBox.Text) || String.IsNullOrEmpty(yearBox.Text))
                        {
                            MessageBox.Show("One or more of the boxes were left blank in the Vehicle Info section. Please fill out every box.", "Vehicle Info Null");
                        }
                        //Issue Text Box Null Check
                        else if (String.IsNullOrEmpty(issueBox.Text))
                        {
                            MessageBox.Show("You have to specify an issue with the vehicle.", "Issue Text Box Null");
                        }
                        else if (String.IsNullOrEmpty(estimatedPriceBox.Text) || String.IsNullOrEmpty(actualPriceBox.Text))
                        {
                            MessageBox.Show("The Estimated Price or Actual Price is empty.", "Price Info Null");
                        }
                        else
                        {
                            ////////////////////////////////////////
                            ///EVERYTHING VALIDATED NEW CODE HERE///
                            ////////////////////////////////////////
                            MessageBox.Show("Validated");
                            








                        }
                    }
                    //If phone number isnt 10 digits long
                    else
                    {
                        MessageBox.Show(phoneNumberBox.Text.Length.ToString());
                        MessageBox.Show("That was an invalid phone number. Make sure you type out only numbers with nothing else. It should be 10 digits long.", "Phone Number Errors");
                    }
                }
                //If phone number has non ints in it
                else
                {
                    MessageBox.Show("That was an invalid phone number. Make sure you type out only numbers with nothing else. It should be 10 digits long.", "Phone Number Errorss");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Your value was in an incorrect format. Please enter only number a number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("That amount was too much. Please enter another amount.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + " : " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Customer Info Reset
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            streetAdressBox.Text = "";
            phoneNumberBox.Text = "";

            //Vehicle Info Reset
            makeBox.SelectedIndex = -1;
            modelBox.SelectedIndex = -1;
            trimBox.SelectedIndex = -1;
            vinBox.Text = "";
            yearBox.SelectedIndex = -1;

            //Issue Box Reset
            issueBox.Text = "";

            estimatedPriceBox.Text = "$0.00";
            actualPriceBox.Text = "$0.00";


        }
        
        
    }
}
