using System;

namespace PrimeSummation
{
    public static class PrimeSummation
    {
        //Returns the Sum of all prime numbers below num.
        public static long SumAllPrimesBelow(int num)
        {
            long sum = 0;
            int[] nums = new int[num];

            num -= 2; // Because 0 1 are not included in primes.

            //Initialize the number array.
            for (int i = 0, j = 2; i < num; i++, j++)
            {
                nums[i] = j;
            }

            //Mark non primes as 0 for the sum
            for (int i = 0; i < nums.Length; i++)
            {
                // If a number is not 0 in the array it's prime.
                if (nums[i] != 0)
                {
                    // Mark all multiples of prime i as 0.
                    for (int j = nums[i]; j < nums.Length; j += nums[i])
                    {
                        if ((i + j) < nums.Length) //Don't go over array size.
                            nums[i + j] = 0;
                    }
                }
            }

            //Sum here
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            return sum;
        }

        static void Main(string[] args)
        {
            int num = 2000000; // Count Primes up to this value (2 mil)
            long sum = 0;

            Console.WriteLine("Sum of all primes under 2 million is = ");

            sum = PrimeSummation.SumAllPrimesBelow(num);

            //sum should be 142913828922
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}