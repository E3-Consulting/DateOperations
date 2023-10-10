using System;
using System.Collections.Generic;

namespace DateOperations
{
    public class DateOps
    {
        // Calculates the number of business days between two given dates, excluding weekends and specified holidays.
        public int DateDiffDays(DateTime from, DateTime to, List<DateTime> holidays)
        {
            int businessDays = 0;

            while (from <= to)
            {
                if (from.DayOfWeek != DayOfWeek.Saturday && from.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(from))
                {
                    businessDays++;
                }
                from = from.AddDays(1);
            }

            return businessDays;
        }
    }
}
