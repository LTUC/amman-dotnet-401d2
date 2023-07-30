namespace SchoolAPI.Models
{
    public class Enrollment
    {
        public int CourseId { get; set; }

        public int StudentId { get; set; }


        // Navigation proparites
        // These specify the connection between these tables
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
