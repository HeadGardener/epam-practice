namespace WhilePractice
{
    public static class Task3
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1;
            while (i <= n)
            {
                sum += 1 / (i * i * i * i * i);
                i++;
            }

            return sum;
        }
    }
}
