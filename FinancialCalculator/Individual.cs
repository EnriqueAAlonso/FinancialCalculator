﻿using FinancialCalculator.Clases;
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

        private void F_P_Click(object sender, EventArgs e)
        {
            sideP.Height = F_P.Height;
            sideP.Top = F_P.Top;
            CalculatorFunction.Status = 1;
            anexo11.Update(1);
        }

        private void P_F_Click(object sender, EventArgs e)
        {
            sideP.Height = P_F.Height;
            sideP.Top = P_F.Top;
            CalculatorFunction.Status = 2;
            anexo11.Update(2);
        }

        private void F_A_Click(object sender, EventArgs e)
        {
            sideP.Height = F_A.Height;
            sideP.Top = F_A.Top;
            CalculatorFunction.Status = 3;
            anexo11.Update(3);
        }

        private void A_F_Click(object sender, EventArgs e)
        {
            sideP.Height = A_F.Height;
            sideP.Top = A_F.Top;
            CalculatorFunction.Status = 4;
            anexo11.Update(4);
        }

        private void P_A_Click(object sender, EventArgs e)
        {
            sideP.Height = P_A.Height;
            sideP.Top = P_A.Top;
            CalculatorFunction.Status = 5;
            anexo11.Update(5);
        }

        private void A_P_Click(object sender, EventArgs e)
        {
            sideP.Height = A_P.Height;
            sideP.Top = A_P.Top;
            CalculatorFunction.Status = 6;
            anexo11.Update(6);
        }

        private void P_G_Click(object sender, EventArgs e)
        {
            sideP.Height = P_G.Height;
            sideP.Top = P_G.Top;
            CalculatorFunction.Status = 7;
            anexo11.Update(7);
        }

        private void A_G_Click(object sender, EventArgs e)
        {
            sideP.Height = A_G.Height;
            sideP.Top = A_G.Top;
            CalculatorFunction.Status = 8;
            anexo11.Update(8);
        }

        private void F_G_Click(object sender, EventArgs e)
        {
            sideP.Height = F_G.Height;
            sideP.Top = F_G.Top;
            CalculatorFunction.Status = 9;
            anexo11.Update(9);
        }

        private void IEF_btn_Click(object sender, EventArgs e)
        {
            sideP.Height = IEF_btn.Height;
            sideP.Top = IEF_btn.Top;
            CalculatorFunction.Status = 10;
            anexo11.Update(10);
        }

        private void AnexoDos_btn_Click(object sender, EventArgs e)
        {
            sideP.Height = AnexoDos_btn.Height;
            sideP.Top = AnexoDos_btn.Top;
            CalculatorFunction.Status = 11;
            anexo11.Update(11);
        }
    }
}
