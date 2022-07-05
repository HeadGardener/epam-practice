namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            if (i == 0)
            {
                return i;
            }

            if (i < 0)
            {
                if (i > -6)
                {
                    return i + 5;
                }
                else
                {
                    return i;
                }
            }
            else
            {
                if (i < 6)
                {
                    return i - 5;
                }
                else
                {
                    return i;
                }
            }
        }
    }
}
