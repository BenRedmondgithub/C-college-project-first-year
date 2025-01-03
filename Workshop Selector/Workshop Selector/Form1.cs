using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }
        
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workShopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            outPutLabel.Text = (" "); // Clear the output label's text

            workShopListBox.SelectedIndex = -1;// Deselect any selected workshop

            locationListBox.SelectedIndex = -1;// Deselect any selected location
        }

        private void calulatebutton_Click(object sender, EventArgs e)
        {   // Initialize variables for registration fee, number of days, and lodging cost
            decimal regfee = 1, days = 1, lodge =1;
            // Check if a workshop is selected in the workshop list box
            if (workShopListBox.SelectedIndex != -1)
                // Determine the registration fee and number of days based on the selected workshop
                switch (workShopListBox.SelectedIndex) 
                { 
                
                    case 0:
                        regfee = 1000.00m;// Fee for the first workshop
                        days = 3; // Duration in days for the first workshop
                        break;

                    case 1:
                        regfee = 500.00m;
                        days = 3;
                        break;

                    case 2:
                        regfee = 1500.00m; // Fee for the second workshop
                        days = 3; // Duration in days for the second workshop
                        break;

                    case 3:
                        regfee = 1300.00m; // Fee for the third workshop
                        days = 5; // Duration in days for the third workshop
                        break;

                    case 4:
                        regfee = 500.00m;// Fee for the fifth workshop
                        days = 1; // Duration in days for the fifth workshop
                        break;
                }
            else
            {   // Show a message box if no workshop is selected
                MessageBox.Show("No Workshop is selected.");
            }
                // Check if a location is selected in the location list box
            if (locationListBox.SelectedIndex != -1)
                // Determine the lodging cost based on the selected location
                switch (locationListBox.SelectedIndex) 
                {
                    case 0:
                    lodge = 300.00M;  // Lodging cost for the first location
                    break;
                    
                    case 1:
                    lodge = 200.00m;  // Lodging cost for the second location
                    break;
                    
                    case 2:
                    lodge = 300.00m;  // Lodging cost for the third location
                    break;
                    
                    case 3:
                    lodge = 200.00m;  // Lodging cost for the fourth location
                    break;
                    
                    case 4:
                    lodge = 400.00m;  // Lodging cost for the fifth location
                    break;
                    
                    case 5:
                    lodge = 150.00m;  // Lodging cost for the sixth location
                    break;
                }
            else
            {   // Show a message box if no location is selected
                MessageBox.Show("No location was Selected");
            }   // Calculate the total cost and display it in the output label
            outPutLabel.Text = (lodge * days + regfee).ToString("c2");
        }
    }
}
