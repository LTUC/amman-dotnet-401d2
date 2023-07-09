using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class StudentsRepository
    {
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student(){ Name = "Abdullah", Grade = 99},
                new Student(){ Name = "Ahmad", Grade = 95},
                new Student(){ Name = "Ala'a", Grade = 97.5f},
                new Student(){ Name = "Bashar", Grade = 93.7f},
                new Student(){ Name = "Eyad", Grade = 80},
                new Student(){ Name = "Zaid", Grade = 85},
                new Student(){ Name = "Yaman", Grade = 82.5f},
            };
        }
    }
}
