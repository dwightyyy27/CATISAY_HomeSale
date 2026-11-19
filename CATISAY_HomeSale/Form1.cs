using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATISAY_HomeSale
{
    public partial class Form1 : Form
    {
        // Step 5: class-level (global) variables that keep each
        // salesperson's running total across many button clicks.
        private double danielleTotal = 0;
        private double edwardTotal = 0;
        private double fatimaTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Step 6: evaluate the initial, update that agent's total,
        // and build the success message.
        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            switch (salesInitial.Trim().ToUpper())
            {
                case "D":
                    danielleTotal += salesAmount;
                    lblDisplay.Text = "Sale of " + salesAmount.ToString("C") +
                        " recorded for Danielle." + Environment.NewLine +
                        "Danielle's total sales: " + danielleTotal.ToString("C");
                    break;

                case "E":
                    edwardTotal += salesAmount;
                    lblDisplay.Text = "Sale of " + salesAmount.ToString("C") +
                        " recorded for Edward." + Environment.NewLine +
                        "Edward's total sales: " + edwardTotal.ToString("C");
                    break;

                case "F":
                    fatimaTotal += salesAmount;
                    lblDisplay.Text = "Sale of " + salesAmount.ToString("C") +
                        " recorded for Fatima." + Environment.NewLine +
                        "Fatima's total sales: " + fatimaTotal.ToString("C");
                    break;

                default:
                    lblDisplay.Text = "Invalid salesperson initial. Please enter D, E, or F.";
                    break;
            }
        }

        // Step 7: reset the textboxes and the display label.
        private void clearEntry()
        {
            txtInitial.Clear();
            txtAmount.Clear();
            lblDisplay.Text = "";
            txtInitial.Focus();
        }

        // Step 8: event handlers
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            double amount;

            if (string.IsNullOrWhiteSpace(txtInitial.Text))
            {
                lblDisplay.Text = "Please enter a salesperson initial.";
                txtInitial.Focus();
                return;
            }

            if (!double.TryParse(txtAmount.Text, out amount) || amount < 0)
            {
                lblDisplay.Text = "Please enter a valid sales amount.";
                txtAmount.Focus();
                return;
            }

            getSalesPerson_Amount(txtInitial.Text, amount);

            // Clear only the inputs so the confirmation message stays visible
            txtInitial.Clear();
            txtAmount.Clear();
            txtInitial.Focus();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        // Opens the summary report form
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            SummaryForm summary = new SummaryForm(danielleTotal, edwardTotal, fatimaTotal);
            summary.ShowDialog();
        }
    }
}
