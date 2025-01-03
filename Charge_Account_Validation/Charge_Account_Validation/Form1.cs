using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charge_Account_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void checkAccButton_Click(object sender, EventArgs e)
        //Create a list to hold the Acccount Details
        {
            List<int> acclist = new List<int>();
            int accountnum = 0;


            //try and Catch Block to read the Account data from the file
            try
            {   // Check if the entered account number is greater than 0
                if (int.Parse(accountNumberTextBox.Text) > 0)
                {   // Parse the account number from the textbox
                    accountnum = int.Parse(accountNumberTextBox.Text);
                }
                else
                {   // Show a message if the entered number is not valid
                    MessageBox.Show("Please Enter number");
                }
            }
            catch
            {   // Show a message if the entered value is not a numeric number
                MessageBox.Show("Enter the numeric number");
            }
            try
            {   // Try block to read the account numbers from the file
                StreamReader inputfile = File.OpenText(@"D:\\programming\\C sharp programs\\assiments\\Charge_Account_Validation\\AccountList.txt");

                while (!inputfile.EndOfStream) 
                {
                    acclist.Add(int.Parse(inputfile.ReadLine()));
                }
                // close the file 
                inputfile.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
                // Try block to check if the entered account number exists in the list
            try
            {

                bool accfound = false;
                // Loop through each account number in the list
                foreach (int acc in acclist)
                {   // If the account number matches the entered account number, set accfound to true
                    if (acc == accountnum)
                    { 
                        accfound = true;
                    }
                } // Show a message based on whether the account number was found or not
                if (accfound) 
                {
                    MessageBox.Show("Entered account number is a valid account number");
                }
                else 
                {
                    MessageBox.Show("Entered account number is not a valid account number");
                }
                // Show a message if there is an exception while checking the account number
            }
            catch (Exception ex)
            
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Event handler for the exit button click
        private void exitButton_Click(object sender, EventArgs e)
        {   // Close the application when the exit button is clicked
            this.Close();
        }
    }
}
