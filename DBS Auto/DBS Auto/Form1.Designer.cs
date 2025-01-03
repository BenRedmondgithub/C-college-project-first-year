namespace DBS_Auto
{
    partial class Form1
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
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTire = new System.Windows.Forms.CheckBox();
            this.chkMufflerReplacement = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.grpNonRoutine = new System.Windows.Forms.GroupBox();
            this.chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.grpRoutine = new System.Windows.Forms.GroupBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpNonRoutine.SuspendLayout();
            this.grpRoutine.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSummary
            // 
            this.lstSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.ItemHeight = 16;
            this.lstSummary.Location = new System.Drawing.Point(509, 133);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(241, 180);
            this.lstSummary.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Your Final Bill: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laborTextBox);
            this.groupBox2.Controls.Add(this.partsTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(230, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 88);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(76, 61);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(82, 20);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(76, 25);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(82, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Labor €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parts:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTire);
            this.groupBox1.Controls.Add(this.chkMufflerReplacement);
            this.groupBox1.Controls.Add(this.chkInspection);
            this.groupBox1.Location = new System.Drawing.Point(230, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 92);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            // 
            // chkTire
            // 
            this.chkTire.AutoSize = true;
            this.chkTire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTire.Location = new System.Drawing.Point(6, 70);
            this.chkTire.Name = "chkTire";
            this.chkTire.Size = new System.Drawing.Size(135, 20);
            this.chkTire.TabIndex = 2;
            this.chkTire.Text = "Tire Rotation (€30)";
            this.chkTire.UseVisualStyleBackColor = true;
            // 
            // chkMufflerReplacement
            // 
            this.chkMufflerReplacement.AutoSize = true;
            this.chkMufflerReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMufflerReplacement.Location = new System.Drawing.Point(6, 40);
            this.chkMufflerReplacement.Name = "chkMufflerReplacement";
            this.chkMufflerReplacement.Size = new System.Drawing.Size(182, 20);
            this.chkMufflerReplacement.TabIndex = 1;
            this.chkMufflerReplacement.Text = "Muffler replacement (€200)";
            this.chkMufflerReplacement.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInspection.Location = new System.Drawing.Point(6, 12);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(119, 20);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection (€10)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 340);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 35);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Pay now";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(301, 340);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(179, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 35);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // grpNonRoutine
            // 
            this.grpNonRoutine.Controls.Add(this.chkTransmissionFlush);
            this.grpNonRoutine.Controls.Add(this.chkRadiatorFlush);
            this.grpNonRoutine.Location = new System.Drawing.Point(33, 221);
            this.grpNonRoutine.Name = "grpNonRoutine";
            this.grpNonRoutine.Size = new System.Drawing.Size(187, 88);
            this.grpNonRoutine.TabIndex = 11;
            this.grpNonRoutine.TabStop = false;
            this.grpNonRoutine.Text = "Flushes";
            // 
            // chkTransmissionFlush
            // 
            this.chkTransmissionFlush.AutoSize = true;
            this.chkTransmissionFlush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransmissionFlush.Location = new System.Drawing.Point(7, 44);
            this.chkTransmissionFlush.Name = "chkTransmissionFlush";
            this.chkTransmissionFlush.Size = new System.Drawing.Size(176, 20);
            this.chkTransmissionFlush.TabIndex = 1;
            this.chkTransmissionFlush.Text = "Transmission flush (€100)";
            this.chkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRadiatorFlush.Location = new System.Drawing.Point(7, 20);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(140, 20);
            this.chkRadiatorFlush.TabIndex = 0;
            this.chkRadiatorFlush.Text = "Radiator flush (€60)";
            this.chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // grpRoutine
            // 
            this.grpRoutine.Controls.Add(this.chkLubeJob);
            this.grpRoutine.Controls.Add(this.chkOilChange);
            this.grpRoutine.Location = new System.Drawing.Point(33, 93);
            this.grpRoutine.Name = "grpRoutine";
            this.grpRoutine.Size = new System.Drawing.Size(183, 92);
            this.grpRoutine.TabIndex = 10;
            this.grpRoutine.TabStop = false;
            this.grpRoutine.Text = "Oil and Lube";
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLubeJob.Location = new System.Drawing.Point(7, 56);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(114, 20);
            this.chkLubeJob.TabIndex = 1;
            this.chkLubeJob.Text = "Lube Job( €20)";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOilChange.Location = new System.Drawing.Point(7, 25);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(124, 20);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "Oil Change (€50)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.grpNonRoutine);
            this.Controls.Add(this.grpRoutine);
            this.Name = "Form1";
            this.Text = "DBS Auto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNonRoutine.ResumeLayout(false);
            this.grpNonRoutine.PerformLayout();
            this.grpRoutine.ResumeLayout(false);
            this.grpRoutine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTire;
        private System.Windows.Forms.CheckBox chkMufflerReplacement;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox grpNonRoutine;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.GroupBox grpRoutine;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.CheckBox chkOilChange;
    }
}

