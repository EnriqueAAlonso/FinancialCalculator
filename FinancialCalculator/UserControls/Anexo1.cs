using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCalculator.Clases;

enum OperationType { FuturoDadoP, PresenteDadoF, FuturoDadoA, AnualidadDadoF, PresenteDadoA, AnualidadDadoP,IEF, Anexo2}
namespace FinancialCalculator.UserControls
{
    public partial class Anexo1 : UserControl
    {   //Declaration of variables
        private OperationType Mode = OperationType.FuturoDadoP;
        private int Period;
        private double inter;
        private double MainValue;
        private CalculatorFunction calc = new CalculatorFunction();

        public Anexo1()
        {
            InitializeComponent();
            //Giving the Combobox values from the enum
            Selection.DataSource = Enum.GetValues(typeof(OperationType)).Cast<OperationType>();
        }

        private void Selection_SelectedIndexChanged(object sender, EventArgs e)
        {//Translation fo the selection of the user
           Enum.TryParse<OperationType>(Selection.SelectedValue.ToString(), out Mode);
            switch (Mode)
            {
                case OperationType.FuturoDadoP:
                    mainValueLabel.Text = "Valor Presente";
                    mainValueLabel.Show();
                    InputValue.Show();
                    break;
                case OperationType.FuturoDadoA:
                    mainValueLabel.Text = "Anualidad";
                    mainValueLabel.Show();
                    InputValue.Show();
                    break;
                case OperationType.PresenteDadoA:
                    mainValueLabel.Text = "Anualidad";
                    mainValueLabel.Show();
                    InputValue.Show();
                    break;
                case OperationType.PresenteDadoF:
                    mainValueLabel.Text="Valor Futuro";
                    mainValueLabel.Show();
                    InputValue.Show();
                    break;
                case OperationType.AnualidadDadoF:
                    mainValueLabel.Text = "Anualidad";
                    mainValueLabel.Show();
                    InputValue.Show();
                    break;
                case OperationType.AnualidadDadoP:
                    mainValueLabel.Show();
                    InputValue.Show();
                    mainValueLabel.Text = "Anualidad";
                    break;
                case OperationType.IEF:
                    mainValueLabel.Hide();
                    InputValue.Hide();
                    break;
                case OperationType.Anexo2:
                     Anexo2 anex= new Anexo2();
                     anex.Show();
                    break;
                default:
                    Mode = OperationType.FuturoDadoP;
                    mainValueLabel.Show();
                    InputValue.Show();
                    break;
            }


        }

        private void PeriodBox_ValueChanged(object sender, EventArgs e)
        {   //Storage of the number of periods selected
            Period = Convert.ToInt32(PeriodBox.Value);

        }

        private void interest_ValueChanged(object sender, EventArgs e)
        {   //Storage of the Interest Value
            inter = Convert.ToDouble(interest.Value / 100);
        }

        private void InputValue_ValueChanged(object sender, EventArgs e)
        {
            //Storage of the main value
            MainValue = Convert.ToDouble(InputValue.Value);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string output = "Valor Futuro";
            double result=0;
            switch (Mode)
            {
                case OperationType.FuturoDadoP:
                    result = calc.FutureGivenPresent(Period,MainValue,inter);
                    output = "El Valor Futuro";
                    break;
                case OperationType.FuturoDadoA:
                    result=calc.FutureGivenPayment(Period, MainValue, inter);
                    output = "El Valor Futuro";
                    break;
                case OperationType.PresenteDadoA:
                    result= calc.PresentGivenPayment(Period, MainValue, inter);
                    output = "El Valor Presente";
                    break;
                case OperationType.PresenteDadoF:
                    result = calc.PresentGivenFuture(Period, MainValue, inter);
                    output = "El Valor Presente";
                    break;
                case OperationType.AnualidadDadoF:
                    result = calc.PaymentGivenFuture(Period, MainValue, inter);
                    output = "La Anualidad";
                    break;
                case OperationType.AnualidadDadoP:
                    result = calc.PaymentGivenFuture(Period, MainValue, inter);
                    output = "La Anualidad";
                    break;
                case OperationType.IEF:
                    result = calc.IEF(inter, Period);
                    output = "El interés efectivo";
                    break;
                default:
                    break;
                    
            }

            result = Math.Round(result, 2);
            MessageBox.Show(output + " es " + result.ToString());

        }
    }
}
