using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinancialCalculator.Clases
{
    class CalculatorFunction
    {
        //Anexo 1
        public double FutureGivenPresent(int numberOfPeriods, double presentValue, double interest)
        {
            return presentValue * Math.Pow((1 + interest), numberOfPeriods);
        }
        public double PresentGivenFuture(int numberOfPeriods, double futureValue, double interest)
        {
            return futureValue * Math.Pow(1 / (1 + interest), numberOfPeriods);
        }
        public double FutureGivenPayment(int numberOfPeriods, double payment, double interest)
        {
            return payment * (Math.Pow(1 + interest, numberOfPeriods) - 1) / interest;
        }
        public double PaymentGivenFuture(int numberOfPeriods, double futureValue, double interest)
        {
            return futureValue * (interest / (Math.Pow(1 + interest, numberOfPeriods) - 1));
        }
        public double PresentGivenPayment(int numberOfPeriods, double payment, double interest)
        {
            //Value of 1+interest, elevated to the power of the number of periods
            double pwr = Math.Pow(1 + interest, numberOfPeriods);
            return payment * (pwr - 1) / (interest * pwr);
        }
        public double PaymentGivenPresent(int numberOfPeriods, double presentValue, double interest)
        {
            //Value of 1+interest, elevated to the power of the number of periods
            double pwr = Math.Pow(1 + interest, numberOfPeriods);
            return presentValue * (interest * pwr) / (pwr - 1);
        }
        //Anexo 2
        public double IEF(double rate, double yearlyPeriods)
        {
            return (Math.Pow(1 + (rate / yearlyPeriods), yearlyPeriods) - 1);
        }
        

        //Anexo 3
    }
}
