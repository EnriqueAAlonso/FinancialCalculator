using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace FinancialCalculator
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Individual individual = new Individual();
            individual.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.google.com/spreadsheets/d/1chLIX9fT_ulpqUw88UZCEZxWQxpIAjvOfPKSiKeNZQk/edit#gid=0");
            Process.Start(sInfo);
        }
    }
}
