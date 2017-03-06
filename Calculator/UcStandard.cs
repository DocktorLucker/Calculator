using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class UcStandard : UserControl
    {
        public UcStandard()
        {
            InitializeComponent();
            TextBox.Text = "0";
        }

        private double a, b;
        private int count = 0;
        private bool znak = true;
        private int last = 0;

        private void TextBoxClear()
        {
            if (TextBox.Text == "0")
            {
                TextBox.Clear();
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains(".") ||
                (double.Parse(TextBox.Text[0].ToString()) != 0 && TextBox.Text.Length >= 1))
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
            TextBoxClear();
            TextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            TextBox.Text += "9";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            ExpressionLabel.Text = string.Empty;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 4;
            ExpressionLabel.Text = a + "/";
            znak = true;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 3;
            ExpressionLabel.Text = a + "*";
            znak = true;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 2;
            ExpressionLabel.Text = a + "-";
            znak = true;
        }

        private double DoubleParse(string number)
        {
            CultureInfo ci = (CultureInfo) CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            return double.Parse(number, NumberStyles.Any, ci);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 1;
            ExpressionLabel.Text = a + "+";
            znak = true;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            Calculate();
            CheckPoints();
            ExpressionLabel.Text = string.Empty;
        }

        private void CheckPoints()
        {
            if (TextBox.Text[TextBox.Text.Length - 1] == '.')
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
        }

        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    CheckPoints();
                    b = a + double.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;

                    break;
                case 2:
                    CheckPoints();
                    b = a - double.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 3:
                    CheckPoints();
                    b = a*double.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 4:
                    CheckPoints();
                    b = a/double.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 5:
                    CheckPoints();
                    b = double.Parse(TextBox.Text);
                    b = a*(b/100);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;

                default:
                    break;
            }
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Clear();
            count = 5;
            ExpressionLabel.Text = a + "%";
            znak = true;
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Clear();
            count = 6;
            ExpressionLabel.Text = a + "√";
            znak = true;
            b = Math.Sqrt(a);
            TextBox.Text = b.ToString();
            ExpressionLabel.Text = String.Empty;
        }

        private void OneDivideXButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Clear();
            count = 6;
            ExpressionLabel.Text = a + "";
            znak = true;
            b = 1/a;
            TextBox.Text = b.ToString();
            ExpressionLabel.Text = String.Empty;
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text[0] != '-')
            {
                TextBox.Text = TextBox.Text.Insert(0, "-");
            }
            else
            {
                TextBox.Text = TextBox.Text.Remove(0, 1);
            }
        }

        private void CeButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty;
        }

        private void UcStandard_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
            if (TextBox.Text.Length == 0)
            {
                TextBox.Text = "0";
            }
        }
    }
}
