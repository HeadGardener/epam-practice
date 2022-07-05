namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0, i = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint r = 3, a = 13;
            uint sum = 0, i = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0, i = 0, el = 0;
            while (el <= maxTerm)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                el = a * rpow;
                if (el <= maxTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0, i = 0, el;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                el = a * rpow;
                if (el >= minTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }
    }
}
