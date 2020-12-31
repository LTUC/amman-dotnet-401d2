using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolEnrollmentDemo.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseCode { get; set; }
        public Technology Technology { get; set; }
        public decimal Price { get; set; }

        // nav properties
        public ICollection<Transcript> Transcripts { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
    public enum Technology
    {
        Python = 1,
        JavaScript,
        [Display(Name = ".NET")]
        DotNet,
        Java
    }
}
