namespace WhilePractice
{
    public static class Task2
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1, pow = 1, j = 0;
            const double t = -1;
            while (i <= n)
            {
                while (j < (i + 1))
                {
                    pow *= t;
                    j++;
                }

                sum += pow / (i * (i + 1));
                i++;
            }

            return sum;
        }
    }
}
