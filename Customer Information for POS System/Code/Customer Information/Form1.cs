// Calvin Tracy
// CS 313 01
// Program Assignment 06 (Final)
// 4/25/2020
// Program to enter customer information stored in Classes using a Super Class and a Sub Class

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Information
{
    public partial class Form1 : Form
    {
        String customerComments = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            customerComments = txtComments.Text;
            //cbNewsLetter.IsChecked = true;
            // Creates an object named "newCustomer" of the Class. Customer.
            // Customer has inherited all the methods from the Person Class
            Customer newCustomer = new Customer();

            try
            {
                newCustomer.lastName = txtLastName.Text;
                newCustomer.firstName = txtFirstName.Text;
                newCustomer.address = txtAddress.Text;
                newCustomer.city = txtCity.Text;
                newCustomer.state = txtState.Text;
                newCustomer.zip = txtZip.Text;
                newCustomer.phone = txtPhone.Text;

                newCustomer.customerNumber = int.Parse(txtCustomerNumber.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Please enter the customer's information.");
            }

            if (cbNewsLetter.Checked)
            {
                MessageBox.Show("Thank you for subscribing to our News Letter!");
            }


            MessageBox.Show(newCustomer.lastName + " " + 
                            newCustomer.firstName + " " + 
                            newCustomer.address + " " +
                            newCustomer.city + " " +
                            newCustomer.city + " " +
                            newCustomer.state + " " +
                            newCustomer.zip + " " +
                            newCustomer.phone);

            MessageBox.Show("Customer Number:" + " " + 
                            newCustomer.customerNumber.ToString() + " " + "\n" +
                            customerComments);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
