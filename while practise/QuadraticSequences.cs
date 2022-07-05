namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long sum = 0, el = 0;
            long i = 1;

            while (el <= maxTerm)
            {
                el = (a * i * i) + (b * i) + c;
                if (el <= maxTerm)
                {
                   sum += el;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long sum = 0, el, temp;
            long i = 1;
            bool ok = true;

            while (ok)
            {
                temp = (a * i * i) + (b * i) + c;
                while (temp > startN)
                {
                    temp /= 10;
                    if (temp == startN || temp % 10 == startN)
                    {
                        while (count != 0)
                        {
                            el = (a * i * i) + (b * i) + c;
                            count--;
                            i++;
                            sum += el;
                        }

                        ok = false;
                    }
                }

                i++;
            }

            return sum;
        }
    }
}
