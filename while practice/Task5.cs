namespace WhilePractice
{
    public static class Task5
    {
        public static double GetSequenceProduct(int n)
        {
            double product = 1, i = 1;
            while (i <= n)
            {
                product *= 1 + (1 / (i * i));
                i++;
            }

            return product;
        }
    }
}
