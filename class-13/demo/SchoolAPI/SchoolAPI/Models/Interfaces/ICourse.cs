namespace SchoolAPI.Models.Interfaces
{
    public interface ICourse
    {
        // Create 
        Task<Course> Create(Course course);

        // GET All
        Task<List<Course>> GetCourses();

        // GET Course By Id

        Task<Course> GetCourse(int courseId);

        // Update
        Task<Course> UpdateCourse(int id, Course course);

        // Delete 

        Task Delete(int id);
    }
}
