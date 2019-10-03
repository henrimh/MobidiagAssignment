using System;

namespace Fibonacci
{
    public static class Fibonacci
    {
        //Sums up the even numbers in fibonaccis sequence up to number num
        public static int SumEvenNumbersUpTo(int num)
        {
            int sum = 0;

            for (int i = 2, previous = 1, previousHelp; i <= num;)
            {
                //If i is even, add it to the sum.
                if (i % 2 == 0)
                    sum += i;

                //Need a helper variable to store and update the previous i value
                previousHelp = i;

                //Update i to the next number in Fibonacci sequence
                i += previous;

                //Finally update previous
                previous = previousHelp;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            int param = 4000000;
            int sum = 0;

            sum = SumEvenNumbersUpTo(param);

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
