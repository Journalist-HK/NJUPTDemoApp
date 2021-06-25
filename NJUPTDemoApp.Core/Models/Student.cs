using System;
using System.Collections.Generic;
using System.Text;

namespace NJUPTDemoApp.Core.Models
{
    public class Student
    {
        public long StudentID { get; set; }

        public double CommonScore { get; set; }

        public double MidScore { get; set; }

        public double FinalScore { get; set; }

        public double Grade => CommonScore * 0.3 + MidScore * 0.3 + MidScore * 0.4;

        public string Mark { get; set; }
    }
}
