using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*************************
* Name: Kerem Goldagi
* Class: ITD-2343-60486
* Trimester: Fall 2026
* Due Date: 10/14/2026
*************************/

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        string bOperator = "";
        decimal dResult = 0.0m;

        public frmMethodActing()
        {
            InitializeComponent();
        }

        //Put Your method here

        private decimal CalculateDisplayResult(in decimal dLeft, in decimal dRight, byte Operator)
        {
            bOperator = "";
            dResult = 0.0m;

            if (dRight == 0 && (Operator == DIVIDE || Operator == MODULUS))
            {
                lblDisplayResult.Text = "Cannot divide by 0 (zero)";
                return dResult;
            }

            else
            {
                switch (Operator)

                {
                    case ADD:
                        dResult = dLeft + dRight;
                        bOperator = "+";
                        break;
                    case SUBTRACT:
                        dResult = dLeft - dRight;
                        bOperator = "-";
                        break;
                    case MULTIPLY:
                        dResult = dLeft * dRight;
                        bOperator = "*";
                        break;
                    case DIVIDE:
                        dResult = dLeft / dRight;
                        dResult = Math.Round(dResult, 2);
                        bOperator = "/";
                        break;

                    case MODULUS:
                        dResult = dLeft % dRight;
                        bOperator = "%";
                        break;
                }

                lblDisplayResult.Text = $"{dLeft} {bOperator} {dRight} = {dResult}";
            }

            return dResult;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);

            dResult = CalculateDisplayResult(dLeft, dRight, ADD);
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            dResult = CalculateDisplayResult(dLeft, dRight, SUBTRACT);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            dResult = CalculateDisplayResult(dLeft, dRight, MULTIPLY);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);

            dResult = CalculateDisplayResult(dLeft, dRight, DIVIDE);
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);

            dResult = CalculateDisplayResult(dLeft, dRight, MODULUS);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblDisplayResult.Text = "";
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDisplayResult_Click(object sender, EventArgs e)
        {

        }

        private void frmMethodActing_Load(object sender, EventArgs e)
        {

        }

        private void txtLeftOperand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
