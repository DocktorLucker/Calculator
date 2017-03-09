using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class UcEngineer : UserControl
    {
        public UcEngineer()
        {
            InitializeComponent();
            TextBox.Text = "0";
        }

        private double a, b;
        private int count = 0;
        private bool znak = true;
        private int last = 0;

        private void RightBracketButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "(";
        }

        private void LeftBracketButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += ")";
        }
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
                    b = double.Parse(TextBox.Text);
                    if (b == 0)
                    {
                        b = 1;
                    }
                    b = a /b;
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
                case 11:
                    CheckPoints();
                    b = double.Parse(TextBox.Text);
                    b = Math.Pow(a, b);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 12:
                    CheckPoints();
                    b = double.Parse(TextBox.Text);
                    b = Math.Pow(a, 1 / b);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;

                default:
                    break;
            }
        }

        private void CalculateForse()
        {
            switch (count)
            {
                case 1:
                    CheckPoints();
                    a = a * Math.PI/180;
                    b = Math.Tan(a) - a;
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 2:
                    CheckPoints();
                    if (a == '-')
                    {
                        b = Math.Log(a);
                    }
                    else
                    {
                        b = 0;
                    }
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 3:
                    CheckPoints();

                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 4:
                    CheckPoints();
                    b = Math.Sinh(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 5:
                    CheckPoints();
                    b = Math.Sin(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 6:
                    CheckPoints();
                    b = a*a;
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 7:
                    CheckPoints();
                    b = 1;
                    for (double i = a; i > 1; i--)
                    {
                        b *= i;
                    }
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 8:
                    CheckPoints();

                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 9:
                    CheckPoints();
                    b = Math.Cosh(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 10:
                    CheckPoints();
                    b = Math.Cos(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 11:
                    CheckPoints();
                    TextBox.Text += "^";
                    b = double.Parse(TextBox.Text);

                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;

                case 13:
                    CheckPoints();
                    b = Math.PI;
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 14:
                    CheckPoints();
                    b = Math.Tanh(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 15:
                    CheckPoints();
                    b = Math.Tan(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 16:
                    CheckPoints();
                    b = a*a*a;
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 17:
                    CheckPoints();
                    b = Math.Exp(a);
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 18:
                    CheckPoints();
                    b = Math.Sqrt(Math.Sqrt(a));
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 19:
                    CheckPoints();
                    if (a == '-')
                    {
                        b = Math.Log(a);
                    }
                    else
                    {
                        b = 0;
                    }
                    TextBox.Text = b.ToString();
                    ExpressionLabel.Text = String.Empty;
                    break;
                case 20:
                    CheckPoints();
                    b = 1;
                    for (int i = 0; i < a; i++)
                    {
                        b = b*10;
                    }
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
            TextBox.Text = "0";
        }

        private void UcStandard_Load(object sender, EventArgs e)
        {

        }

        private void InvButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 1;
            CalculateForse();
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 2;
            
            CalculateForse();
        }
        private void IntButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 3;
            CalculateForse();
        }

        private void SinhButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 4;
            CalculateForse();
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 5;
            CalculateForse();
        }

        private void SqrButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 6;
            CalculateForse();
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 7;
            CalculateForse();
        }

        private void DmsButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 8;
            CalculateForse();
        }

        private void CoshButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 9;
            CalculateForse();
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 10;
            CalculateForse();
        }

        private void StepinButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 11;
        }

        private void SqrtYButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 12;
        }

        private void PiButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 13;
            CalculateForse();
        }

        private void TanhButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 14;
            CalculateForse();
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 15;
            CalculateForse();
        }

        private void KubButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 16;
            CalculateForse();
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 17;
            CalculateForse();
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text[0] == '-')
            {
                TextBox.Text = TextBox.Text.Remove(0,1);
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 19;
            CalculateForse();
        }

        private void TenButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 20;
            CalculateForse();
        }

        private void KubSqrtButton_Click(object sender, EventArgs e)
        {
            a = DoubleParse(TextBox.Text);
            TextBox.Text = "0";
            count = 18;
            CalculateForse();
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
