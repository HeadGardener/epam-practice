namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i == 0)
            {
                return i;
            }

            if (i < 0)
            {
                if (i > -4)
                {
                    return i * 3;
                }
                else
                {
                    return i;
                }
            }
            else
            {
                if (i < 4)
                {
                    return i - (i * i);
                }
                else
                {
                    return i;
                }
            }
        }
    }
}
