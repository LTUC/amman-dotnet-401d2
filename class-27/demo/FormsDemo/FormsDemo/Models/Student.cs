using System.ComponentModel.DataAnnotations;

namespace FormsDemo.Models
{

    /// <summary>
    ///  Display(int firstOne, string secound, string Name)
    ///  
    /// Display(Name = "")
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Range(15, 30)]
        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

        public string GPA { get; set; }
    }
}
