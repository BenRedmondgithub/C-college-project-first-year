namespace popularity
{
    partial class popularityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstResults = new System.Windows.Forms.ListBox();
            this.Calulatebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtDailyIncrease = new System.Windows.Forms.TextBox();
            this.txtStartingOrganisms = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(449, 46);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(279, 329);
            this.lstResults.TabIndex = 0;
            // 
            // Calulatebutton
            // 
            this.Calulatebutton.Location = new System.Drawing.Point(89, 211);
            this.Calulatebutton.Name = "Calulatebutton";
            this.Calulatebutton.Size = new System.Drawing.Size(223, 63);
            this.Calulatebutton.TabIndex = 1;
            this.Calulatebutton.Text = "Go!";
            this.Calulatebutton.UseVisualStyleBackColor = true;
            this.Calulatebutton.Click += new System.EventHandler(this.Calulatebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(89, 375);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(223, 63);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(89, 148);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(223, 20);
            this.txtDays.TabIndex = 2;
            // 
            // txtDailyIncrease
            // 
            this.txtDailyIncrease.Location = new System.Drawing.Point(89, 96);
            this.txtDailyIncrease.Name = "txtDailyIncrease";
            this.txtDailyIncrease.Size = new System.Drawing.Size(223, 20);
            this.txtDailyIncrease.TabIndex = 2;
            // 
            // txtStartingOrganisms
            // 
            this.txtStartingOrganisms.Location = new System.Drawing.Point(89, 40);
            this.txtStartingOrganisms.Name = "txtStartingOrganisms";
            this.txtStartingOrganisms.Size = new System.Drawing.Size(223, 20);
            this.txtStartingOrganisms.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(89, 300);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(223, 60);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // popularityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.txtStartingOrganisms);
            this.Controls.Add(this.txtDailyIncrease);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Calulatebutton);
            this.Controls.Add(this.lstResults);
            this.Name = "popularityForm";
            this.Text = "Popularity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button Calulatebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtDailyIncrease;
        private System.Windows.Forms.TextBox txtStartingOrganisms;
        private System.Windows.Forms.Button clearButton;
    }
}

