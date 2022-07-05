namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1)
            {
                if (b2)
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i > 0)
                    {
                        if (i > 1 && i < 10)
                        {
                            return 10 - i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                    else
                    {
                        if (i < -1 && i > -10)
                        {
                            return i + 5;
                        }
                        else
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i > 0)
                    {
                        if (i > 1 && i < 10)
                        {
                            return 10 + i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                    else
                    {
                        if (i < -1 && i > -10)
                        {
                            return 5 - i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                }
            }
            else
            {
                if (b2)
                {
                    if (i == 0)
                    {
                        return 1;
                    }

                    if (i > 0)
                    {
                        if (i == 1 || i == 10)
                        {
                            return 11;
                        }

                        if (i > 1 && i < 5)
                        {
                            return 10 + i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                    else
                    {
                        if (i == -10)
                        {
                            return -9;
                        }

                        if (i > -5)
                        {
                            return 10 + i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        return -1;
                    }

                    if (i > 0)
                    {
                        if (i == 10)
                        {
                            return 9;
                        }

                        if (i < 5)
                        {
                            return -10 + i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                    else
                    {
                        if (i == -10)
                        {
                            return -11;
                        }

                        if (i > -5)
                        {
                            return -10 + i;
                        }
                        else
                        {
                            return i;
                        }
                    }
                }
            }
        }
    }
}
