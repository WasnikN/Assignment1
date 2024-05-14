using System.Numerics;

namespace Assignment1.Assignments
{
    public class Factorial
    {
        public BigInteger Calculate(BigInteger number)
        {
            BigInteger result = 1;

            for (BigInteger i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
