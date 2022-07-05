namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            if (i == 0)
            {
                return false;
            }

            if (b)
            {
                if ((i > 3 && i < 7) || (i < -3 && i > -7))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if ((i > 2 && i < 7) || (i < -2 && i > -7))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
