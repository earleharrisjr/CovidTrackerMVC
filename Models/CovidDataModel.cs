using System;
using System.Globalization;

namespace CovidTrackingMVC.Models
{    public class CovidDataModel
    {
        public int Date { get; set; }
        public string State { get; set; }
        public int Positive { get; set; }
        public int? Negative { get; set; }
        public int? Hospitalized { get; set; }
        public int Total { get; set; }


        public static void convertDate(int[] args)
        {
        CovidDataModel c = new CovidDataModel();
        int date = c.Date;
        int year = date / 10_000;
        int month = (date - year * 10_000) / 100;
        int day = date % 100;
        DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine(dateTime.ToString());
        }

}


}
