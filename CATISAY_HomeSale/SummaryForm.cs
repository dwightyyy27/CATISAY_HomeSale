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
    public partial class SummaryForm : Form
    {
        public SummaryForm(double danielle, double edward, double fatima)
        {
            this.Text = "Sales Summary Report";
            this.ClientSize = new System.Drawing.Size(340, 190);
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblReport = new Label();
            lblReport.AutoSize = false;
            lblReport.Location = new System.Drawing.Point(20, 20);
            lblReport.Size = new System.Drawing.Size(300, 110);
            lblReport.Text =
                "Danielle:  " + danielle.ToString("C") + Environment.NewLine +
                "Edward:    " + edward.ToString("C") + Environment.NewLine +
                "Fatima:    " + fatima.ToString("C") + Environment.NewLine + Environment.NewLine +
                "Total Sales: " + (danielle + edward + fatima).ToString("C");

            Button btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Location = new System.Drawing.Point(120, 140);
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblReport);
            this.Controls.Add(btnClose);
        }
    }
}