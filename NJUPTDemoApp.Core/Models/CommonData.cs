using System;
using System.Collections.Generic;
using System.Text;

namespace NJUPTDemoApp.Core.Models
{
    public class CommonData
    {

        public static string Source;

        public static string[] mystr;

        public static double Amount;

        public static List<Foo> Excellentfoos;

        public static List<Foo> Goodfoos;

        public static List<Foo> Secondaryfoos;

        public static List<Foo> Passfoos;

        public static List<Foo> NotPassfoos;

        public static double ExcellentRate;

        public static double GoodRate;

        public static double SecondaryRate;

        public static double PassRate;

        public static double NotPassRate;

        public static string ExcellentjsonData;

        public static string GoodjsonData;

        public static string SecondaryjsonData;

        public static string PassjsonData;

        public static string NotPassjsonData;

        public static string OutString;
    }

    public class Foo
    {
        public string StudentID { get; set; }

        public double UsualPerformance { get; set; }

        public double MidTermExamResult { get; set; }

        public double FinalExamResult { get; set; }

        public double TotalMark { get; set; }

        public string EqualRank { get; set; }

    }
}
