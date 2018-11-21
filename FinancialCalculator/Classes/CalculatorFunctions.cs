//Anexo 1
public double FutureGivenPresent(int numberOfPeriods, double presentValue, double interest)
{
	return presentValue*Math.pow( (1+interest) , numberOfPeriods);
}
public double PresentGivenFuture(int numberOfPeriods, double futureValue, double interest)
{
	return futureValue*Math.pow(1/(1+interest),numberOfPeriods);
}
public double FutureGivenPayment(int numberOfPeriods, double payment, double interest)
{
	return payment*( Math.pow(1+interest,numberOfPeriods)-1 )/interest;
}
public double PaymentGivenFuture(int numberOfPeriods, double futureValue, double interest)
{
	return futureValue*( interest/(Math.pow(1+interest,numberOfPeriods)-1) );
}
public double PresentGivenPayment(int numberOfPeriods, double payment, double interest)
{
	//Value of 1+interest, elevated to the power of the number of periods
	double pwr=Math.pow(1+interest,numberOfPeriods);
	return payment*( pwr-1 )/ ( interest * pwr );
}
public double PaymentGivenPresent(int numberOfPeriods, double presentValue, double interest)
{
	//Value of 1+interest, elevated to the power of the number of periods
	double pwr=Math.pow(1+interest,numberOfPeriods);
	return presentValue*( interest*pwr )/ ( pwr-1 );
}
//Anexo 2
public double IEF(double rate, double yearlyPeriods)
{
	return ( Math.pow( 1+( rate/yearlyPeriods ) , yearlyPeriods ) - 1);
}
