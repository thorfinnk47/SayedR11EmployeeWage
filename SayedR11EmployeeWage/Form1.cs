using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayedR11EmployeeWage
{
    public partial class Form1 : Form
    {
        private string PayType;
        const string CONTRACTOR = "Contractor";
        const string HOURLY = "Hourly";
        const string SALARIED = "Salaried";

        //declared the form2 object
        private Form2 settingForm;

        private string OvertimeLog = "OvertimeLog.txt";
        private string OvertimeRates = "OvertimeRates.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want to quit?", "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoursWorked.Clear();
            txtEmployeeName.Clear();
            txtHourlyRate.Clear();
            lstOutput.Items.Clear();
            txtEmployeeName.Focus();
        }


        private void btnCalculateTotalEarn_Click(object sender, EventArgs e)
        {
            string EmployeeName;
            double HoursWorked;
            double HourlyRate;
            bool RateValid, WorkedValid;
            double RegPay;
            double TotalPay;
            double OTPay = 0;
            double PayTypeRate = 0;
            StreamWriter sw;



            //Input 
            //Parse converts string to double
            //HourlyRate = double.Parse(txtHourlyRate.Text);
            //HoursWorked = double.Parse(txtHoursWorked.Text);
            //convert parse to tryparse
            RateValid = double.TryParse(txtHourlyRate.Text, out HourlyRate);
            WorkedValid = double.TryParse(txtHoursWorked.Text, out HoursWorked);

            if (RateValid && WorkedValid)
            {

                switch (PayType)
                {
                    case CONTRACTOR:
                        PayTypeRate = 1;
                        break;
                    case HOURLY:
                        PayTypeRate = 1.5;
                        break;
                    case SALARIED:
                        PayTypeRate = 0;
                        break;
                    default:
                        lstOutput.Items.Add(" this shouldn't happen");

                        break;

                }
                if (HoursWorked > 40 || PayType == SALARIED)
                {
                    OTPay = PayTypeRate * HourlyRate * (HoursWorked - 40);
                    RegPay = 40 * HourlyRate;

                }
                else
                {
                    RegPay = HoursWorked * HourlyRate;
                }
                EmployeeName = txtEmployeeName.Text;


                //Processing


                TotalPay = OTPay + RegPay;





                //Output
                lstOutput.Items.Add("Employee Name is " + EmployeeName);
                lstOutput.Items.Add("Pay Classification is " + PayType);
                lstOutput.Items.Add("Overtime Rate " + PayTypeRate);
                lstOutput.Items.Add("Overtime Pay is " + OTPay.ToString("C2"));
                lstOutput.Items.Add("Hourly Rate is " + HourlyRate.ToString("C2"));
                lstOutput.Items.Add("Hours Worked is " + HoursWorked.ToString("N2"));
                lstOutput.Items.Add("Total Wages are " + TotalPay.ToString("C2"));

                sw = File.AppendText(OvertimeLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + " **********");
                sw.WriteLine("Employee Name is " + EmployeeName);
                // updated output
                sw.WriteLine("Pay Classification is " + PayType);
                sw.WriteLine("Overtime Rate is " + PayTypeRate.ToString("C"));
                sw.WriteLine("Overtime Pay is" + OTPay.ToString("C2"));
                sw.WriteLine("Hourly Rate is " + HourlyRate.ToString("C2"));
                sw.WriteLine("Hours Worked is " + HoursWorked.ToString("N2"));
                sw.WriteLine("Total Wages are " + TotalPay.ToString("C2"));

                sw.Close();
                btnClear.Focus();

            }
            else
            {
                if (!RateValid)
                {
                    lstOutput.Items.Add("Please enter a numeric value for hourly rate");
                }
                if (!WorkedValid)
                {
                    lstOutput.Items.Add("Please enter a numeric value for hours worked");
                }
            }

            //This changes the focus to the clear button




            btnClear.Focus();

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_Enter(object sender, EventArgs e)
        {
            txtEmployeeName.BackColor = Color.Bisque;
        }

        private void txtEmployeeName_Leave(object sender, EventArgs e)
        {
            txtEmployeeName.BackColor = SystemColors.Window;
        }

    

        

        






//private void rdoContractor_CheckedChanged(object sender, EventArgs e)
//{

//    if (rdoContractor.Checked)
//    {
//        PayType = CONTRACTOR;
//    }

//}

//private void rdoHourly_CheckedChanged(object sender, EventArgs e)
//{
//    if (rdoHourly.Checked)
//    {
//        PayType = HOURLY;
//    }
//}

//private void rdoSalaried_CheckedChanged(object sender, EventArgs e)
//{
//    if (rdoSalaried.Checked)
//    {
//        PayType = SALARIED;
//    }




//private void mnuSettings_Click(object sender, EventArgs e)
//{
//settingForm.txtContractor.Text = CONTRACTOR.ToString();
//settingForm.txtHourly.Text = HOURLY.ToString();
//settingForm.txtSalaried.Text = SALARIED.ToString();
//settingForm.ShowDialog();
//}










//      public void setvaluesonsecondform()
//      { 
//         settingform.txtcontractor.text = contractor.tostring();
//         settingform.txthourly.text = hourly.tostring();
//         settingform.txtsalaried.text = salaried.tostring();
//      }
//    }
//}
