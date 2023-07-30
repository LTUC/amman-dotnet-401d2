namespace SchoolAPI.Models.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public List<CourseDTO> CourseDTOs { get; set; }
    }

    public class CourseDTO
    {
        public string CourseCode { get; set; }

        public string Technology { get; set; }
    }

    public class NewStudentDto
    {
        public string Name { get; set; }

        public DateTime DOP { get; set; }
    }
}
