using System;
using System.Globalization;

namespace CovidTrackingMVC.Models
{
    public class CovidDataModel
    {
        public int Date { get; set; }
        public string State { get; set; }
        public int Positive { get; set; }
        public int? Negative { get; set; }
        public int? Hospitalized { get; set; }
        public int Total { get; set; }

        public string FormattedDate
        {
            get
            {
                int year = Date / 10000;
                int month = (Date % 10000) / 100;
                int day = Date % 100;
                return string.Format("{0}-{1:D2}-{2:D2}", month, day, year);
            } }
    }


}
