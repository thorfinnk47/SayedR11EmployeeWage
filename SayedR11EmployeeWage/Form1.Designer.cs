namespace SayedR11EmployeeWage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCalculateTotalEarn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.grpPayClassification = new System.Windows.Forms.GroupBox();
            this.rdoSalaried = new System.Windows.Forms.RadioButton();
            this.rdoHourly = new System.Windows.Forms.RadioButton();
            this.rdoContractor = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPayClassification.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(903, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paystub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(589, 163);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(378, 31);
            this.txtEmployeeName.TabIndex = 2;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            this.txtEmployeeName.Enter += new System.EventHandler(this.txtEmployeeName_Enter);
            this.txtEmployeeName.Leave += new System.EventHandler(this.txtEmployeeName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hourly Rate:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(589, 265);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(6);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(378, 31);
            this.txtHourlyRate.TabIndex = 6;
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 31;
            this.lstOutput.Location = new System.Drawing.Point(311, 341);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(6);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(1282, 345);
            this.lstOutput.TabIndex = 7;
            this.lstOutput.TabStop = false;
            // 
            // btnCalculateTotalEarn
            // 
            this.btnCalculateTotalEarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotalEarn.Location = new System.Drawing.Point(314, 761);
            this.btnCalculateTotalEarn.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculateTotalEarn.Name = "btnCalculateTotalEarn";
            this.btnCalculateTotalEarn.Size = new System.Drawing.Size(238, 158);
            this.btnCalculateTotalEarn.TabIndex = 8;
            this.btnCalculateTotalEarn.Text = "Calculate Total &Earnings";
            this.btnCalculateTotalEarn.UseVisualStyleBackColor = true;
            this.btnCalculateTotalEarn.Click += new System.EventHandler(this.btnCalculateTotalEarn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(837, 777);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(260, 142);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(1343, 762);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(250, 154);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours Worked:";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(589, 214);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(378, 31);
            this.txtHoursWorked.TabIndex = 4;
            this.txtHoursWorked.TextChanged += new System.EventHandler(this.txtHoursWorked_TextChanged);
            // 
            // grpPayClassification
            // 
            this.grpPayClassification.Controls.Add(this.rdoSalaried);
            this.grpPayClassification.Controls.Add(this.rdoHourly);
            this.grpPayClassification.Controls.Add(this.rdoContractor);
            this.grpPayClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayClassification.Location = new System.Drawing.Point(300, 68);
            this.grpPayClassification.Name = "grpPayClassification";
            this.grpPayClassification.Size = new System.Drawing.Size(942, 86);
            this.grpPayClassification.TabIndex = 0;
            this.grpPayClassification.TabStop = false;
            this.grpPayClassification.Text = "Pay Classification";
            this.grpPayClassification.Enter += new System.EventHandler(this.grpPayClassification_Enter);
            // 
            // rdoSalaried
            // 
            this.rdoSalaried.AutoSize = true;
            this.rdoSalaried.Location = new System.Drawing.Point(537, 42);
            this.rdoSalaried.Name = "rdoSalaried";
            this.rdoSalaried.Size = new System.Drawing.Size(173, 41);
            this.rdoSalaried.TabIndex = 2;
            this.rdoSalaried.TabStop = true;
            this.rdoSalaried.Text = "Salaried";
            this.rdoSalaried.UseVisualStyleBackColor = true;
            this.rdoSalaried.CheckedChanged += new System.EventHandler(this.rdoSalaried_CheckedChanged);
            // 
            // rdoHourly
            // 
            this.rdoHourly.AutoSize = true;
            this.rdoHourly.Location = new System.Drawing.Point(306, 42);
            this.rdoHourly.Name = "rdoHourly";
            this.rdoHourly.Size = new System.Drawing.Size(146, 41);
            this.rdoHourly.TabIndex = 1;
            this.rdoHourly.TabStop = true;
            this.rdoHourly.Text = "Hourly";
            this.rdoHourly.UseVisualStyleBackColor = true;
            this.rdoHourly.CheckedChanged += new System.EventHandler(this.rdoHourly_CheckedChanged);
            // 
            // rdoContractor
            // 
            this.rdoContractor.AutoSize = true;
            this.rdoContractor.Location = new System.Drawing.Point(14, 42);
            this.rdoContractor.Name = "rdoContractor";
            this.rdoContractor.Size = new System.Drawing.Size(209, 41);
            this.rdoContractor.TabIndex = 0;
            this.rdoContractor.TabStop = true;
            this.rdoContractor.Text = "Contractor";
            this.rdoContractor.UseVisualStyleBackColor = true;
            this.rdoContractor.CheckedChanged += new System.EventHandler(this.rdoContractor_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2740, 48);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(120, 44);
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1654);
            this.Controls.Add(this.grpPayClassification);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateTotalEarn);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Paystub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPayClassification.ResumeLayout(false);
            this.grpPayClassification.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCalculateTotalEarn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.GroupBox grpPayClassification;
        private System.Windows.Forms.RadioButton rdoSalaried;
        private System.Windows.Forms.RadioButton rdoHourly;
        private System.Windows.Forms.RadioButton rdoContractor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
    }
}

