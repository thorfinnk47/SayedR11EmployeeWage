namespace SayedR11EmployeeWage
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContractor = new System.Windows.Forms.TextBox();
            this.txtHourly = new System.Windows.Forms.TextBox();
            this.txtSalaried = new System.Windows.Forms.TextBox();
            this.btnSetReturn = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contractor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salaried";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 4;
            // 
            // txtContractor
            // 
            this.txtContractor.Location = new System.Drawing.Point(266, 100);
            this.txtContractor.Name = "txtContractor";
            this.txtContractor.Size = new System.Drawing.Size(208, 31);
            this.txtContractor.TabIndex = 5;
            this.txtContractor.Leave += new System.EventHandler(this.txtContractor_Leave);
            // 
            // txtHourly
            // 
            this.txtHourly.Location = new System.Drawing.Point(269, 168);
            this.txtHourly.Name = "txtHourly";
            this.txtHourly.Size = new System.Drawing.Size(195, 31);
            this.txtHourly.TabIndex = 6;
            this.txtHourly.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSalaried
            // 
            this.txtSalaried.Location = new System.Drawing.Point(266, 240);
            this.txtSalaried.Name = "txtSalaried";
            this.txtSalaried.Size = new System.Drawing.Size(208, 31);
            this.txtSalaried.TabIndex = 7;
            // 
            // btnSetReturn
            // 
            this.btnSetReturn.Location = new System.Drawing.Point(185, 462);
            this.btnSetReturn.Name = "btnSetReturn";
            this.btnSetReturn.Size = new System.Drawing.Size(289, 116);
            this.btnSetReturn.TabIndex = 9;
            this.btnSetReturn.Text = "&Set & Return";
            this.btnSetReturn.UseVisualStyleBackColor = true;
            this.btnSetReturn.Click += new System.EventHandler(this.btnSetReturn_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(325, 381);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 31);
            this.lblErrorMsg.TabIndex = 10;
            this.lblErrorMsg.Leave += new System.EventHandler(this.lblErrorMsg_Leave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 888);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnSetReturn);
            this.Controls.Add(this.txtSalaried);
            this.Controls.Add(this.txtHourly);
            this.Controls.Add(this.txtContractor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Paystub Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetReturn;
        public System.Windows.Forms.TextBox txtContractor;
        public System.Windows.Forms.TextBox txtHourly;
        public System.Windows.Forms.TextBox txtSalaried;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}