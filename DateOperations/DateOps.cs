using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOperations
{
    public class DateOps
    {
        public int DateDiffDays(string dateFormat, string from, string to)
        {
            DateTime fromDate = DateTime.ParseExact(from, dateFormat, CultureInfo.InvariantCulture);
            DateTime toDate = DateTime.ParseExact(to, dateFormat, CultureInfo.InvariantCulture);
            TimeSpan dateDiff = fromDate - toDate;
            return Math.Abs(dateDiff.Days);
        }
    }
}
