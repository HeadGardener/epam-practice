namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            uint i = 0, count = 0;
            if (n == 0 || n == 1)
            {
                return false;
            }

            while (i != (n / 2))
            {
                i++;
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                return true;
            }

            return false;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint i = 2, number = 0, count;

            if (n == 2 || n == 3)
            {
                return n;
            }

            while (i <= n)
            {
                uint j = 0;
                count = 0;
                while (j * j < i)
                {
                    j++;
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    number = i;
                }

                i++;
            }

            return number;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint i, c, temp = 0, sum = 0;
            while (n > 1)
            {
                i = n;
                uint j = 0;
                c = 0;
                while (j != (i / 2))
                {
                    j++;
                    if (i % j == 0)
                    {
                        c++;
                    }
                }

                if (c == 1)
                {
                    sum += i;
                    temp++;
                }

                if (temp == count)
                {
                    break;
                }

                n--;
            }

            return sum;
        }
    }
}
