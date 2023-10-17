using System;
using System.Collections.Generic;

namespace DateOperations
{
    public class DateOps
    {
        /// <summary>
        /// Calculates the number of business days between two dates, excluding weekends and holidays.
        /// </summary>
        /// <param name="from">The starting date.</param>
        /// <param name="to">The ending date.</param>
        /// <param name="holidays">A list of holiday dates.</param>
        /// <returns>The number of business days between the two dates.</returns>
        public int CalculateBusinessDays(DateTime from, DateTime to, List<DateTime> holidays)
        {
            int businessDays = 0;
            int totalDays = (int)(to - from).TotalDays;
            for (int i = 0; i <= totalDays; i++)
            {
                DateTime currentDate = from.AddDays(i);
                if (IsBusinessDay(currentDate, holidays))
                {
                    businessDays++;
                }
            }
            return businessDays;
        }


        /// <summary>
        /// Determines if a given date is a business day.
        /// </summary>
        /// <param name="date">The date to check.</param>
        /// <param name="holidays">The list of holidays.</param>
        /// <returns>True if the date is a business day, false otherwise.</returns>
        private bool IsBusinessDay(DateTime date, List<DateTime> holidays)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            return dayOfWeek != DayOfWeek.Saturday
                && dayOfWeek != DayOfWeek.Sunday
                && !holidays.Contains(date);
        }

        /// <summary>
        /// Calculates the number of business days (excluding Sundays and holidays) between two dates.
        /// </summary>
        /// <param name="from">The starting date.</param>
        /// <param name="to">The ending date.</param>
        /// <param name="holidays">A list of holiday dates.</param>
        /// <returns>The number of business days between the two dates.</returns>
        public int CalculateBusinessDaysIncludeSaturdays(DateTime from, DateTime to, List<DateTime> holidays)
        {
            int businessDays = 0;

            int totalDays = (int)(to - from).TotalDays + 1;

            for (int i = 0; i < totalDays; i++)
            {
                DateTime currentDay = from.AddDays(i);

                if (currentDay.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(currentDay))
                {
                    businessDays++;
                }
            }

            return businessDays;
        }
    }
}
