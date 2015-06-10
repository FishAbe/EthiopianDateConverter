using System;
using System.Collections.Generic;

using System.Text;


namespace AmharicDateConverter
{
    public static class EthiopianDates
    {
       
        public static string ToEthiopianDateFormat(DateTime date)
        {
            if (date.Date.Equals(DateTime.Parse("1/1/0001")))
                return string.Empty;

                DateHelper ethiopianDate = new DateHelper(date);
                return ethiopianDate.ToLongDateString();
           
        }

    }
}
