using Microsoft.VisualBasic;
using System.Text;
namespace C_Learning
{
    public class Program
    {

        public static void Main(String[] args)
        {

            //********** 1. RomanNumeralsEncoder

            int romanCase1 = 1992;
            int romanCase2 = 1585;

            Console.WriteLine("Roman equivalent of the year " + romanCase1 + " is " + RomanNumeralsEncoder.Solution(romanCase1) + ".");
            Console.WriteLine("Roman equivalent of the year " + romanCase2 + " is " + RomanNumeralsEncoder.Solution(romanCase2) + ".");
            Console.WriteLine();

            //********** 2. ProductOfConsecutiveFibNumbers

             ulong fibonacci1 = 87841;
             ulong fibonacci2 = 98643843;

             Console.Write("Numbers " + ProductOfConsecutiveFibNumbers.ProductFib(fibonacci1)[0] + " and " + ProductOfConsecutiveFibNumbers.ProductFib(fibonacci1)[1] + " from Fibonacci sequence ");
             if (ProductOfConsecutiveFibNumbers.ProductFib(fibonacci1)[2] == 1)
            {
                Console.WriteLine("are products of the number " + fibonacci1 + ".");
            }
            else
            {
                Console.WriteLine("are not products of the number " + fibonacci1 + ", but result of their multiplication is smaller than " + fibonacci1 +
                "\n" + "(result of multiplication of " + ProductOfConsecutiveFibNumbers.ProductFib(fibonacci1)[1] + " + next number of Fibonacci sequence will be grater than " + fibonacci1 + ").");
            }

            Console.Write("Numbers " + ProductOfConsecutiveFibNumbers.ProductFib(fibonacci2)[0] + " and " + ProductOfConsecutiveFibNumbers.ProductFib(fibonacci2)[1] + " from Fibonacci sequence ");
            if (ProductOfConsecutiveFibNumbers.ProductFib(fibonacci2)[2] == 1)
            {
                Console.WriteLine("are products of the number " + fibonacci2 + ".");
            }
            else
            {
                Console.WriteLine("are not products of the number " + fibonacci2 + ", but result of their multiplication is smaller than " + fibonacci2 +
                        "\n" + "(result of multiplication of " + ProductOfConsecutiveFibNumbers.ProductFib(fibonacci2)[1] + " + next number of Fibonacci sequence will be grater than " + fibonacci2 + ").");
            }
            Console.WriteLine();

        }
    }
}





