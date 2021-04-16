using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingproject2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string operation = "";
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;

            //Radio Buttons

            if (radioButton1.Checked) 
            {
                label1.Text = "cm";
                label2.Text = "cm";
                label3.Text = "cm";
            }

            if (radioButton2.Checked) 
            {
                label1.Text = "in";
                label2.Text = "in";
                label3.Text = "in";
            }

            
            if (double.TryParse(textBox1.Text, out firstNumber)) { }
            else {
                MessageBox.Show("Invalid Input for First Number. Must be a positive number. Try again. ");
            }
            if (double.TryParse(textBox2.Text, out secondNumber)) { }
            else {
                MessageBox.Show("Invalid Input for Second Number. Must be a positive number. Try Again:");
            }

            if (operationChooser.SelectedIndex != -1)
            {
                //Get the Selected Index
                operation = operationChooser.SelectedItem.ToString();

                switch (operation)
                {
                    case "Addition":
                        result = firstNumber + secondNumber;
                        break;
                    case "Subtraction":
                        result = firstNumber - secondNumber;
                        break;
                    case "Multiplication":
                        result = firstNumber * secondNumber;
                        break;
                    case "Division":
                        result = firstNumber / secondNumber;
                        break;
                }
            }
            else
            {
                //No Operation was Selected
                MessageBox.Show("You did not select an Operation. Try Again.");
            }
            resultOutput.Text = result.ToString();

            //Check Boxes
            if (checkBoxBold.Checked)
            {
                resultOutput.Font = new Font("Arial", 12, FontStyle.Bold);
            }

            if (checkBoxItalcized.Checked)
            {
                resultOutput.Font = new Font("Arial", 12, FontStyle.Italic);
            }

            if (checkBoxUnderline.Checked)
            {
                resultOutput.Font = new Font("Arial", 12, FontStyle.Underline);
            }

        }

        private void operationChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
