namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            if (i >= 0)
            {
                return i;
            }
            else if (i < 0 && i > -6)
            {
                return -i;
            }
            else
            {
                return -(i * i);
            }
        }

        public static int DoSomething2(int i)
        {
            if (i >= 0)
            {
                return i;
            }
            else if (i < 0 && i > -6)
            {
                return -i;
            }
            else
            {
                return -(i * i);
            }
        }
    }
}
