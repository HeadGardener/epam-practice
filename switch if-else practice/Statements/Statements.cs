using System;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("Number {0} is the largest", first);
                }
                else
                {
                    Console.WriteLine("Number {0} is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("Number {0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("Number {0} is the largest", third);
                }
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second ? true : false)
            {
                if (first > third ? true : false)
                {
                    Console.WriteLine("Number {0} is the largest", first);
                }
                else
                {
                    Console.WriteLine("Number {0} is the largest", third);
                }
            }
            else
            {
                if (second > third ? true : false)
                {
                    Console.WriteLine("Number {0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("Number {0} is the largest", third);
                }
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
           if (first > second && first > third)
           {
                Console.WriteLine("Number {0} is the largest", first);
           }
           else if (second > first && second > third)
           {
                Console.WriteLine("Number {0} is the largest", second);
           }
           else
           {
                Console.WriteLine("Number {0} is the largest", third);
           }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }

            if (userAge >= 21 && userAge < 65)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }

            if (userAge >= 18 && userAge < 21)
            {
                Console.WriteLine("You're old enough to drive.");
            }

            if (userAge < 18)
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }

            if (countOfDailyDownloads >= 1 && countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }

            if (countOfDailyDownloads >= 100 && countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }

            if (countOfDailyDownloads >= 1000 && countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }

            if (countOfDailyDownloads >= 10000 && countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }

            if (countOfDailyDownloads >= 100000)
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The weekend.");
            }

            if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The middle of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend.");
                    break;

                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;

                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }
            else if (arg is byte)
            {
                return $"{arg} is byte.";
            }
            else if (arg is short)
            {
                return $"{arg} is short.";
            }
            else if (arg is int)
            {
                return $"{arg} is int.";
            }
            else if (arg is long)
            {
                return $"{arg} is long.";
            }
            else if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }
            else if (arg is uint)
            {
                return $"{arg} is uint.";
            }
            else if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }
            else
            {
                return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte:
                    return $"{arg} is sbyte.";

                case byte:
                    return $"{arg} is byte.";

                case short:
                    return $"{arg} is short.";

                case int:
                    return $"{arg} is int.";

                case long:
                    return $"{arg} is long.";

                case ushort:
                    return $"{arg} is ushort.";

                case uint:
                    return $"{arg} is uint.";

                case ulong:
                    return $"{arg} is ulong.";

                default:
                    return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg) => arg switch
        {
            sbyte => $"{arg} is sbyte.",
            byte => $"{arg} is byte.",
            short => $"{arg} is short.",
            int => $"{arg} is int.",
            long => $"{arg} is long.",
            ushort => $"{arg} is ushort.",
            uint => $"{arg} is uint.",
            ulong => $"{arg} is ulong.",
            _ => $"{arg} is not integer.",
        };

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;

                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;

                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;

                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;

                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number >= 0)
            {
                if (number < 10)
                {
                    return 1;
                }

                if (number < 100)
                {
                    return 2;
                }

                if (number < 1000)
                {
                    return 3;
                }

                if (number < 10000)
                {
                    return 4;
                }

                if (number < 100000)
                {
                    return 5;
                }

                if (number < 1000000)
                {
                    return 6;
                }

                if (number < 10000000)
                {
                    return 7;
                }

                if (number < 100000000)
                {
                    return 8;
                }

                if (number < 1000000000)
                {
                    return 9;
                }

                return 10;
            }
            else
            {
                if (number > -10)
                {
                    return 1;
                }

                if (number > -100)
                {
                    return 2;
                }

                if (number > -1000)
                {
                    return 3;
                }

                if (number > -10000)
                {
                    return 4;
                }

                if (number > -100000)
                {
                    return 5;
                }

                if (number > -1000000)
                {
                    return 6;
                }

                if (number > -10000000)
                {
                    return 7;
                }

                if (number > -100000000)
                {
                    return 8;
                }

                if (number > -1000000000)
                {
                    return 9;
                }

                return 10;
            }
        }

        public static byte GetLengthWithSwitchExpression(int number) => number switch
        {
            <= -10 and > -100 => 2,
            <= -100 and > -1000 => 3,
            <= -1000 and > -10000 => 4,
            <= -10000 and > -100000 => 5,
            <= -100000 and > -1000000 => 6,
            <= -1000000 and > -10000000 => 7,
            <= -10000000 and > -100000000 => 8,
            <= -100000000 and > -1000000000 => 9,
            <= -1000000000 => 10,
            < 10 and > -10 => 1,
            >= 10 and < 100 => 2,
            >= 100 and < 1000 => 3,
            >= 1000 and < 10000 => 4,
            >= 10000 and < 100000 => 5,
            >= 100000 and < 1000000 => 6,
            >= 1000000 and < 10000000 => 7,
            >= 10000000 and < 100000000 => 8,
            >= 100000000 and < 1000000000 => 9,
            >= 1000000000 => 10,
        };

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }
            else if (month == 2)
            {
                return Month.February;
            }
            else if (month == 3)
            {
                return Month.March;
            }
            else if (month == 4)
            {
                return Month.April;
            }
            else if (month == 5)
            {
                return Month.May;
            }
            else if (month == 6)
            {
                return Month.June;
            }
            else if (month == 7)
            {
                return Month.July;
            }
            else if (month == 8)
            {
                return Month.August;
            }
            else if (month == 9)
            {
                return Month.September;
            }
            else if (month == 10)
            {
                return Month.October;
            }
            else if (month == 11)
            {
                return Month.November;
            }
            else if (month == 12)
            {
                return Month.December;
            }
            else
            {
                return null;
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;

                default:
                    return null;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month) => month switch
        {
            1 => Month.January,
            2 => Month.February,
            3 => Month.March,
            4 => Month.April,
            5 => Month.May,
            6 => Month.June,
            7 => Month.July,
            8 => Month.August,
            9 => Month.September,
            10 => Month.October,
            11 => Month.November,
            12 => Month.December,
            < 1 or > 12 => null,
        };
    }
}
