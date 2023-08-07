namespace SchoolAPI.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseCode { get; set; }

        public int TechnologyId { get; set; }

        public List<Enrollment> Enrollments { get; set; }
        public Technology Technology { get; set; }
    }
}
