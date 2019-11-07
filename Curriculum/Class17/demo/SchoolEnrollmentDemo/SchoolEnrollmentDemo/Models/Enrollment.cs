using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolEnrollmentDemo.Models
{
    public class Enrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        // Nav Props
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
