using System.Numerics; 

namespace C_Learning
{

    class ProductOfConsecutiveFibNumbers
    {
        // Based on https://www.codewars.com/kata/5541f58a944b85ce6d00006a/train/csharp

        public static ulong[] ProductFib(ulong prod)
        {
            BigInteger product_fib = new BigInteger(prod);
            BigInteger[] fibonacci_seq = new BigInteger[93];
            fibonacci_seq[0] = BigInteger.Zero;
            fibonacci_seq[1] = BigInteger.One;

   
            for (int i = 2; i < 93; i++)
            {
                fibonacci_seq[i] = fibonacci_seq[i - 1] + fibonacci_seq[i - 2];
            }

            ulong[] result = new ulong[3];
            bool found = false; 

            for (int i = 0; i < 92; i++)
            {
                if (fibonacci_seq[i] * fibonacci_seq[i + 1] == product_fib) 
                {
                    result[0] = (ulong)fibonacci_seq[i];
                    result[1] = (ulong)fibonacci_seq[i + 1];
                    result[2] = 1; 
                    found = true;
                    break; 
                }
            }

            if (!found) 
            {
                BigInteger[] multiplication = new BigInteger[92];

                for (int i = 0; i < 92; i++)
                {
                    multiplication[i] = fibonacci_seq[i] * fibonacci_seq[i + 1];
                }

                int j = 0;

                for (int i = 91; i > -1; i--)
                {
                    if (multiplication[i] < product_fib)
                    {
                        j++;
                    }
                }

                result[0] = (ulong)fibonacci_seq[j];
                result[1] = (ulong)fibonacci_seq[j + 1];
                result[2] = 0; 
            }

            return result;
        }
    }
}
