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
using System.Diagnostics;

namespace FinancialCalculator
{
    public partial class Individual : Form
    {
        public Individual()
        {
            InitializeComponent();
        }

        private void F_P_Click(object sender, EventArgs e)
        {
            sideP.Height = F_P.Height;
            sideP.Top = F_P.Top;
            CalculatorFunction.Status = 1;
            modeTitle.Text = "Valor futuro (F/P)";
            anexo11.Update(1);
        }

        private void P_F_Click(object sender, EventArgs e)
        {
            sideP.Height = P_F.Height;
            sideP.Top = P_F.Top;
            CalculatorFunction.Status = 2;
            modeTitle.Text = "Valor presente (P/F)";
            anexo11.Update(2);
        }

        private void F_A_Click(object sender, EventArgs e)
        {
            sideP.Height = F_A.Height;
            sideP.Top = F_A.Top;
            CalculatorFunction.Status = 3;
            modeTitle.Text = "Valor futuro (F/A)";
            anexo11.Update(3);
        }

        private void A_F_Click(object sender, EventArgs e)
        {
            sideP.Height = A_F.Height;
            sideP.Top = A_F.Top;
            CalculatorFunction.Status = 4;
            modeTitle.Text = "Fondo de amortización (A/F)";
            anexo11.Update(4);
        }

        private void P_A_Click(object sender, EventArgs e)
        {
            sideP.Height = P_A.Height;
            sideP.Top = P_A.Top;
            CalculatorFunction.Status = 5;
            modeTitle.Text = "Valor presente (P/A)";
            anexo11.Update(5);
        }

        private void A_P_Click(object sender, EventArgs e)
        {
            sideP.Height = A_P.Height;
            sideP.Top = A_P.Top;
            CalculatorFunction.Status = 6;
            modeTitle.Text = "Recuperación de capital (A/P)";
            anexo11.Update(6);
        }
        
        private void IEF_btn_Click(object sender, EventArgs e)
        {
            sideP.Height = IEF_btn.Height;
            sideP.Top = IEF_btn.Top;
            CalculatorFunction.Status = 10;
            modeTitle.Text = "Interés Efectivo (IEF)";
            anexo11.Update(10);
        }

        private void AnexoDos_btn_Click(object sender, EventArgs e)
        {
            sideP.Height = AnexoDos_btn.Height;
            sideP.Top = AnexoDos_btn.Top;
            ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.google.com/spreadsheets/d/1bbsOpwuWvY_DhMl5TsN7G4nb4I8fVWl04Gez-mAAW5o/edit#gid=1130947443");
            Process.Start(sInfo);
        }
    }
}
