using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolEnrollmentDemo.Models
{
    public class Transcript
    {
        public int ID { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }
        public bool Passed { get; set; }

        // Nav props
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
