namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            if (i == 0)
            {
                return false;
            }

            if (b)
            {
                if ((i > 4 && i < 9) || (i < -4 && i > -9))
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
                if ((i > 3 && i < 8) || (i < -4 && i > -9))
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
