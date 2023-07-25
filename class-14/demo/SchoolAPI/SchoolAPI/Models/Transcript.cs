namespace SchoolAPI.Models
{
    public class Transcript
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public double Grade { get; set; }

        public bool Passed { get; set; }

        // Navigation proparites
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
