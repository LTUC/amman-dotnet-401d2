using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolEnrollmentDemo.Models.Interfaces
{
    interface IStudentManager
    {
        Task<IEnumerable<Student>> GetStudents();

        Task UpdateStudent(Student student);

        IEnumerable<Transcript> GetTranscripts(int studentId);

        Task<bool> DeleteStudent(int id);

        Task CreateStudent(Student student);

        Task<bool> Exists(int id);

        Task<Student> GetStudent(int Id);
    }
}
