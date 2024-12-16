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
    public partial class Form2 : Form
    {
        //this is the constructor

        private Form1 ff;
        public Form2(Form1 form1)

        {
            ff = form1;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSetReturn_Click(object sender, EventArgs e)
        {
            //read values from text boxes
            bool contractorValid, hourlyValid, salariedValid;
            double otrTempValue, cTempValue, hTempValue, sTempValue;
            
            StreamWriter sw;

           
            contractorValid = double.TryParse(txtContractor.Text, out cTempValue);
            hourlyValid = double.TryParse(txtHourly.Text, out hTempValue);
            salariedValid = double.TryParse(txtSalaried.Text, out sTempValue);
            //check values
            if (contractorValid && hourlyValid && salariedValid)
            {

                //if values good
                //set properties
                ff.ContractorRate = cTempValue;
                ff.HourlyRate = hTempValue;
                ff.SalariedRate = sTempValue;
                sw = File.CreateText(ff.OvertimeConfig);
                sw.Close();
                sw.WriteLine(ff.ContractorRate);
                sw.WriteLine(ff.HourlyRate);
                sw.WriteLine(ff.SalariedRate);

                //save values in file

                //go back to Form 1
                this.Hide();

                //if values not good 
                //replace all text box values with current values

                ff.setValuesOnSecondForm();


                //is there another way to do this?
            }
        }

        private void lblErrorMsg_Leave(object sender, EventArgs e)
        {

        }

        private void txtContractor_Leave(object sender, EventArgs e)
        {
            bool contractorValid = false;
            double cTempValue;
            contractorValid = double.TryParse(txtContractor.Text, out cTempValue);
            if (!contractorValid || cTempValue >= 1 || cTempValue > 0)
            {
                txtContractor.Focus();
                lblErrorMsg.Text = "Contractor rate is not valid";

            }
            else
            {
                lblErrorMsg.Text = "";
            }
        }

    }

}
