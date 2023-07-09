namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new StudentsRepository().GetStudents();


            //List<Student> greaterThanOrEqualTo90 = students.Where()



            /// using LINQ Extention methods
            var studentsGrade90 = students
                .Where(s => s.Grade >= 90)
                .OrderBy(x => x.Name)
                .Select(x => x.Name);
                ;

          

            ///// Linq Query Perator
            ///

            var listOfStudenetsWithQO = from student in students
                                        where student.Grade >= 90
                                        orderby student.Name
                                        select student.Name


            foreach (var student in studentsGrade90)
            {
                Console.WriteLine(student);
            }



            //foreach (var student in students)
            //{

            //    if (student.Grade >= 90)
            //    {
            //        greaterThanOrQualTo90.Add(student);
            //    }

            //}


        }
    }
}