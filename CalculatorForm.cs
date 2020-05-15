using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        string opertaionPerformed = "";
        double result = 0;
        bool isOperated = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if ((inputtextBox.Text == "0") || (isOperated))
            {
                inputtextBox.Clear();
            }
            isOperated = false;
            Button button = (Button)sender;

            if (button.Text==".")
            {
                if (!inputtextBox.Text.Contains("."))
                    inputtextBox.Text = inputtextBox.Text + button.Text;
            }
            else
            { 
                inputtextBox.Text = inputtextBox.Text + button.Text;
            }
         
          
        }

        private void Operator_ClickEvent(object sender, EventArgs e)
        {
            if (result!=0)
            {
                button19.PerformClick();
                Button button = (Button)sender;
                opertaionPerformed = button.Text;
             
                currentOpertion.Text = result + " " + opertaionPerformed;
                isOperated = true;
            }
            else
            {
                Button button = (Button)sender;
                opertaionPerformed = button.Text;
                result = double.Parse(inputtextBox.Text);
                currentOpertion.Text = result + " " + opertaionPerformed;
                isOperated = true;
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputtextBox.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputtextBox.Text = "0";
            result = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (opertaionPerformed)
            {
                case "+":
                 inputtextBox.Text = (result + double.Parse(inputtextBox.Text)).ToString();
                    break;
                case "-":
                    inputtextBox.Text = (result - double.Parse(inputtextBox.Text)).ToString();
                    break;
                case "*":
                    inputtextBox.Text = (result * double.Parse(inputtextBox.Text)).ToString();
                    break;
                case "/":
                    inputtextBox.Text = (result / double.Parse(inputtextBox.Text)).ToString();
                    break;
                default:
                    break;
            }

            result = double.Parse(inputtextBox.Text);
            currentOpertion.Text = "";
        }
    }
}
