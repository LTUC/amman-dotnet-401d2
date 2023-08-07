namespace SchoolAPI.Models.DTO
{
    public class StudentDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public List<CourseDto> Courses { get; set; }
    }

    public class CourseDto
    {
        public string CourseCode { get; set; }

        public string Technology { get; set; }
    }

    public class NewStudentDto
    {
        public string Name { get; set; }

        public DateTime DOP { get; set; }

        public string CourseCode { get; set; }
    }

    public class StudentGradeDto
    {
        public string CourseCode { get; set; }
        public string Grade { get; set; }
    }
}
