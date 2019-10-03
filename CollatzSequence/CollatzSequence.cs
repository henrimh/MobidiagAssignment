using System;

namespace Collatz
{
    public static class CollatzSequence
    {

        public static int SolveSequenceLength(int num)
        {
            int sequenceLength = 1;

            //Convert to long because some values could go over int size.
            long x = num;

            //Sequence ends to number one
            while (x != 1) 
            {
                sequenceLength++;

                // Collatz sequence rules
                if (x % 2 == 0)
                    x /= 2;
                else
                    x = x * 3 + 1;
            }

            return sequenceLength;
        }

        //Solves the longest CollatzSequence for a number under max.
        public static int SolveLongestSequenceStartingUnder(int max)
        {
            int longestSequence = 0;
            int sequenceLength = 1;

            for (int i = 1; i < max; i++)
            {
                sequenceLength = SolveSequenceLength(i);

                if (sequenceLength > longestSequence)
                    longestSequence = sequenceLength;
            }

            return longestSequence; 
        }


        static void Main(string[] args)
        {
            int param = 1000000;
            int answer;

            answer = SolveLongestSequenceStartingUnder(param);

            Console.WriteLine(answer);
        }
    }
}
