using FinancialCalculator.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculator
{
    public partial class Individual : Form
    {

        public Individual()
        {
            InitializeComponent();
        }

        private void Individual_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //lblRes.Text = "IEF = " + Math.Round(CalculatorFunction.IEF((double)numRate.Value, (double)numPeriods.Value),2);
        }
    }
}
