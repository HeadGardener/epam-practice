using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            if ((x * x) + (y * y) > 100)
            {
                return 0;
            }
            else if ((x * x) + (y * y) <= 100 && (x * x) + (y * y) > 25)
            {
                return 1;
            }
            else if ((x * x) + (y * y) <= 25 && (x * x) + (y * y) > 1)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
