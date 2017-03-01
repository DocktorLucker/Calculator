using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {    
            if (TextBox.Text.Contains(".") || TextBox.Text.Length == 0)
            {
                TextBox.Text += "0";
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void SexButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length>0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
        }
    }
}
