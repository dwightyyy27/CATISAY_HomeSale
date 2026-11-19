namespace CATISAY_HomeSale
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();

            
            this.lblGuide.AutoSize = true;
            this.lblGuide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGuide.Location = new System.Drawing.Point(20, 15);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Text = "Salesperson Codes:  D - Danielle,  E - Edward,  F - Fatima";

           
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(20, 60);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Text = "Enter Sales Person Initial :";

            
            this.txtInitial.Location = new System.Drawing.Point(220, 57);
            this.txtInitial.MaxLength = 1;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(120, 23);

            
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 100);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Text = "Amount of Sale :";

       
            this.txtAmount.Location = new System.Drawing.Point(220, 97);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 23);

           
            this.Btn_Submit.Location = new System.Drawing.Point(20, 145);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(100, 32);
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);

            
            this.Btn_Clear.Location = new System.Drawing.Point(140, 145);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(100, 32);
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);

           
            this.Btn_Print.Location = new System.Drawing.Point(260, 145);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(100, 32);
            this.Btn_Print.Text = "Print";
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);

            
            this.lblDisplay.AutoSize = false;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(20, 195);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(420, 90);
            this.lblDisplay.Text = "";

            
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 305);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Home Sales Tracking Application";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Label lblDisplay;
    }
}

