using SchoolAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Interfaces
{
    public interface IStudent
    {
        // CREATE
        Task<StudentDTO> Create(NewStudentDto student);

        // GET ALL

        Task<List<StudentDTO>> GetStudents();

        // GET ONE BY ID
        Task<StudentDTO> GetStudent(int id);

        // UPDATE
        Task<Student> UpdateStudent(int id, Student student);

        // DELETE
        Task Delete(int id);
    }
}