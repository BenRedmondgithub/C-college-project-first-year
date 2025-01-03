using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popularity
{
    public partial class popularityForm : Form
    {
        public popularityForm()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calulatebutton_Click(object sender, EventArgs e)
        {
            {
                // Retrieve input values from TextBoxes
                if (!double.TryParse(txtStartingOrganisms.Text, out double startingOrganisms) ||
                    !double.TryParse(txtDailyIncrease.Text, out double dailyIncrease) ||
                    !int.TryParse(txtDays.Text, out int days))
                {
                    MessageBox.Show("Please enter valid numerical values.");
                    return;
                }

                // Convert the daily increase percentage to a decimal
                double dailyIncreaseDecimal = dailyIncrease / 100;

                // Add the header to the ListBox
                lstResults.Items.Add("Day\tApproximate Population");

                double currentPopulation = startingOrganisms;

                for (int day = 1; day <= days; day++) 
                {
                    lstResults.Items.Add($"{day}\t{currentPopulation:F2}");

                    // Calculate the next day's population based on the daily increase
                    currentPopulation *= 1 + dailyIncreaseDecimal;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            txtStartingOrganisms.Text = string.Empty;
            
            txtDailyIncrease.Text = string.Empty;
            
            txtDays.Text = string.Empty;
        }
    }
}
