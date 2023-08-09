using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models
{
    
    public class Student
    {

        public int Id { get; set; }


        [Required]
        public string FirstName { get; set; }

        [Required]

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        public List<Transcript> Transcripts { get; set; }

    }
}
