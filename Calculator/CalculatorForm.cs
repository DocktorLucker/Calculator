using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        UcEngineer _ucEngineer = new UcEngineer();
        UcStandard ucStandard = new UcStandard();
        public CalculatorForm()
        {
            InitializeComponent();
            this.Width = 245;
            this.Height = 292;
            this.Controls.Add(ucStandard);
        }


        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 480;
            this.Height = 295;
            this.Controls.RemoveAt(1);
            this.Controls.Add(_ucEngineer);
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 245;
            this.Height = 292;
            this.Controls.RemoveAt(1);
            this.Controls.Add(ucStandard);
        }
    }
}
