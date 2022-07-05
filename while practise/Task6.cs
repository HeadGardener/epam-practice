namespace WhilePractice
{
    public static class Task6
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1, pow = 1, j = 0;
            const double t = -1;
            while (i <= n)
            {
                while (j < i)
                {
                    pow *= t;
                    j++;
                }

                sum += pow / ((2 * i) + 1);
                i++;
            }

            return sum;
        }
    }
}
