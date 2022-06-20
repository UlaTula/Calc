namespace Calc_v2;

public class CalculationException : Exception
{
    public CalculationException()
    {

    }

    public CalculationException(string message) : base (message)
    {

    }

    public CalculationException (string message, Exception exception)
    {

    }
}
