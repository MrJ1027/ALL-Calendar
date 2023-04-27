namespace yearcnl
{
    internal class Program
    {

        /// <summary>
        /// 判断闰年
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        private static bool Is_leap_Year(int year)
        {
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    return true;
            //}
            //else
            //    return false;
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? true : false;
        }
        /// <summary>
        /// 计算一个月有多少天
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        private static int HowManyDay(int year, int month)
        {
            if (month < 1 || month > 12)
            {
                return 0;
            }
            else
            {
                switch (month)
                {
                    case 2:
                        return Is_leap_Year(year) ? 29 : 28;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:
                        return 31;
                }

            }
        }
        /// <summary>
        /// 根据年月日，计算星期数
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
            private static int GetWeekByDay(int year, int month, int day)
            {
                DateTime dt = new DateTime(year, month, day);
                return (int)dt.DayOfWeek;
            }

        private static void MonthCnd(int year, int month)
        {
            Console.WriteLine("{0}年{1}月", year, month);
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六");
            int week = GetWeekByDay(year, month, 1);//留空，打印第一天
            for(int i=0; i<week; i++)
            {
                Console.Write("\t");
            }
            for(int i=1; i<=HowManyDay(year,month); i++)
            {
                Console.Write(i+"\t");
                if(GetWeekByDay(year,month,i)==6)
                {
                    Console.WriteLine();
                }

            }
        }
        private static void PrintYearCnd(int year)
        {
            for(int i=1; i<=12; i++)
            {
                MonthCnd(year, i);
                Console.WriteLine();
            }
        }
            static void Main(string[] args)
            {
            Console.WriteLine("please enter a year");
            int year=int.Parse(Console.ReadLine());
            PrintYearCnd(year);
            }
        
    }
}