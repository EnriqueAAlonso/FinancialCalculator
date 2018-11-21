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
enum OperationType { FuturoDadoP, PresenteDadoF, FuturoDadoA, AnualidadDadoF, PresenteDadoA, ADadoPresente }
namespace FinancialCalculator.UserControls
{
    public partial class Anexo1 : UserControl
    {
        private List<OperationType> Data = new List<OperationType>();

        public Anexo1()
        {
            InitializeComponent();
            Selection.DataSource = Data;
        }

        private void Selection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
