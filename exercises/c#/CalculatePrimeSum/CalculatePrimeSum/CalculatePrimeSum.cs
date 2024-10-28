namespace CalculatePrimeSum;

public static class CalculatePrimeSum
{
    public static int CalculatePrime(this int number)
    {
        if (number < 2)
        {
            throw new ArgumentException("The number must be greater than or equal to 2.");
        }
        
        int result = 0;

        for (int i = 2; i <= number; i++)
        {
            if (i.IsPrime())
            {
                result += i;
            }
        }

        return result;
    }

    private static bool IsPrime(this int number)
    {
        if (number <= 1) return false;
        if(number == 2) return true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        
        return true;
    }
}