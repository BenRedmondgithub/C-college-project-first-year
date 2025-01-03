using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Constants for the costs of various services
        private const double OIL_CHANGE = 50.00;
        private const double LUBE_JOB = 20.00;
        private const double RADIATOR_FLUSH = 60.00;
        private const double TRANSMISSION_FLUSH = 100.00;
        private const double INSPECTION_COST = 10.00;
        private const double MUFFLER_REPLACEMENT = 200.00;
        private const double TIRE_ROTATION = 30.00;
        private const double LABOR_COST = 30.00;
        private const double TAX_RATE = 0.10;
        private double partsTax = 0.0;
        private double parts = 0.0;
        private double labor = 0.0;

        // Method to calculate the total charge for oil change and/or lube job
        private double OilLubeCharges()
        {
            double oilLubeCharges = 0.0;

            // Check if the oil change checkbox is checked, if so, add the oil change cost

            if (chkOilChange.Checked)
            {
                oilLubeCharges += OIL_CHANGE;
            }
            // Check if the lube job checkbox is checked, if so, add the lube job cost
            if (chkLubeJob.Checked)
            {
                oilLubeCharges += LUBE_JOB;
            }

            return oilLubeCharges;
        }

        // Method to calculate the total charges for radiator flush and/or transmission flush

        private double FlushCharges() 
        { 
            double flushCharges = 0.0;

            if (chkOilChange.Checked)
            { // Check if the radiator flush checkbox is checked, if so, add the radiator flush cost
                flushCharges += RADIATOR_FLUSH;
            }
            // Check if the transmission flush checkbox is checked, if so, add the transmission flush cost
            if (chkTransmissionFlush.Checked) 
            { 
                flushCharges += TRANSMISSION_FLUSH;
            }
            return flushCharges;
        }
        // Method to calculate the total charges for inspection, muffler replacement, and/or tire rotation
        private double MiscCharges() 
        { 

        double MiscCharges = 0.0;
            // Check if the inspection checkbox is checked, if so, add the inspection cost
            if (chkInspection.Checked) 
            {
                MiscCharges += INSPECTION_COST;
            }
            // Check if the muffler replacement checkbox is checked, if so, add the muffler replacement cost
            if (chkMufflerReplacement.Checked)
            {
                MiscCharges += MUFFLER_REPLACEMENT;
            }
            // Check if the tire rotation checkbox is checked, if so, add the tire rotation cost
            if (chkTire.Checked)
            {
                MiscCharges += TIRE_ROTATION;
            }

            return MiscCharges;

        }

        // Method to calculate the total charges for other services (parts and labor)

        private double OtherCharges()
        {


            double otherCharges = 0.0;

            // Try to parse the parts cost from the parts textbox, add to total and calculate tax

            if (double.TryParse(partsTextBox.Text, out parts))
            {
                otherCharges += parts;
                partsTax = (parts);
                lstSummary.Items.Clear();
            }
            else
            {
                MessageBox.Show("Enter parts amount.");
            }

            // Try to parse the labor hours from the labor textbox, add to total

            if (double.TryParse(laborTextBox.Text, out labor))
            {
                otherCharges += labor;
            }
            else
            {
                MessageBox.Show("Enter labor amount.");
            }

            return otherCharges;
        }

        // Method to calculate the amount of sales tax on parts

        private double TaxCharges(double parts)
        {
            return parts * partsTax;
        }
        // Method to calculate the total charges for all services
        private double TotalCharges(double oilLubeCharges, double flushCharges,
            double miscCharges, double otherCharges, double partsTax)
        {
            return oilLubeCharges + flushCharges + miscCharges + otherCharges + partsTax;
        }


        // Event handler for the exit button click, closes the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the Clear button click

        private void clearButton_Click(object sender, EventArgs e)
        {   // Clear all checkboxes for routine maintenance
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;

            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;

            chkInspection.Checked = false;
            chkMufflerReplacement.Checked = false;
            chkTire.Checked = false;
            // Clear the textboxes for parts and labor
            partsTextBox.Text = "";
            laborTextBox.Text = "";
            // Clear the summary listbox
            lstSummary.Items.Clear();
        }
        // Event handler for the Calculate button click
        private void calculateButton_Click(object sender, EventArgs e)
        {   // Calculate the charges for each category
            double oilLubeCharge = OilLubeCharges();
            double flushCharge = FlushCharges();
            double miscCharge = MiscCharges();
            double otherCharge = OtherCharges();
            double taxTotal = partsTax;
            double grandTotal = TotalCharges(oilLubeCharge, flushCharge, miscCharge, otherCharge, taxTotal);

            // Display the summary of charges in the listbox

            lstSummary.Items.Clear();
            lstSummary.Items.Add("Summary of Charges:");
            lstSummary.Items.Add($"Oil/Lube Charges: €{oilLubeCharge:F2}");
            lstSummary.Items.Add($"Flush Charges: €{flushCharge:F2}");
            lstSummary.Items.Add($"Misc Charges: €{miscCharge:F2}");
            lstSummary.Items.Add($"Other Charges: €{otherCharge:F2}");
            lstSummary.Items.Add($"Tax Charges: €{taxTotal:F2}");
            lstSummary.Items.Add($"Total Charges: €{grandTotal:F2}");

        }
    }
}
