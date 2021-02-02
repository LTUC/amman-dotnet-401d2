# Demos: Data Transfer Objects (DTOs)

Use this document to describe the demo(s). Generally, this is going to take the format of either how to build the demo step by step, or less specifically, talking points surrounding the outcomes of the demo segment and code snippets to highlight.

## DTOs - OUTBOUND

Create new "models" that define what our API will be returning

- Under models, create a new folder
  - `api` or `dto` is appropriate
-  Within, create a new Class
  - `StudentDto.cs`
- Define what we actually want to show the end user
  - What data is appropriate?
  - What data is relevant?
  - What data should be hidden?

### Create a simple DTO for a student

```csharp
public class StudentDto
{
  public int id { get; set; }
  public DateTime DateOfBirth { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public List<StudentGradeDto> Grades { get; set; }
}

public class StudentGradeDto
{
  public string CourseCode { get; set; }
  public string Technology { get; set; }
  public string Grade { get; set; }
}
```

### Change the controller to specify that DTO

Once you have the DTO created and organized, change the Controller to specify THAT as the return type instead of the student model

```csharp
// GET: api/Students/5
[HttpGet("{id}")]
public async Task<ActionResult<StudentDto>> GetStudent(int id)
{
  StudentDto student = await _student.GetOne(id);
  return student;
}

```

### Alter the Interface to implement that DTO

1. Change the IStudentRepository to specify the new return type
   ```csharp
   // Get one by id
   Task<StudentDto> GetOne(int id);
   ```

### Alter the service to Return that DTO

Here, we'll be writing a large LINQ query that joins the students and transcripts

You'll need to walk the students through the models and their navigation properties, looking at the data to ensure that everyone has a complete understanding of where this data is coming from.

Some highlights
- The `ToString()` call on the grade is using the Enum to convert the number value to a string
- We get the technology name from the navigation property that joins the course to the technology table
- We're making grades a "Select" from the other DTO we created, rather than hand-filling each field
  - This might seem too abstract, but it goes to shape and source of data
- Notice that we can't just "add new fields" here to the output, the DTO now governs it

```csharp
public async Task<StudentDto> GetOne(int id)
{

  // Convert a student from a raw student from the database into a curated student DTO instead1

  return await _context.Students
                .Select(student => new StudentDto
                {
                  Id = student.Id,
                  FirstName = student.FirstName,
                  LastName = student.LastName,
                  DateOfBirth = student.DateOfBirth,
                  Grades = student.Transcripts
                    .Select(t => new StudentGradeDto
                    {
                      CourseCode = t.Course.CourseCode,
                      Technology = t.Course.Technology.Name,
                      Grade = t.Grade.ToString(),
                    }).ToList()
                })
                .FirstOrDefaultAsync(s => s.Id == id);
}
```

### Test a route

i.e. http://localhost:PORT/api/students/1

```json
{
    "id": 1,
    "dateOfBirth": "0001-01-01T00:00:00",
    "firstName": "John",
    "lastName": "Cokos",
    "grades": [
        {
            "courseCode": "seattle-dotnet-401d12",
            "technology": "Node.js",
            "grade": "B"
        },
        {
            "courseCode": "seattle-javascript-401n17",
            "technology": "Node.js",
            "grade": "A"
        }
    ]
}
```


## DTOs - INBOUND

Just as we can create and adhere to an **outbound data contract** using DTOs in our APIs, we can similarly create a contract for data coming into our API, either through a **POST** or a **PUT/PATCH**

Doing so, allows us to shield the API client from having to handle every field of information, and even better, allowing them to specify data that the API will use to perhaps populate multiple tables with the single request.

For example, rather than adding a student, and then enrolling them in a course as 2 separate API calls, why not allow a POST like this:

**http://api.com/api/student/course**

```json
{
  "FirstName": "Suzie",
  "LastName": "Sample",
  "CourseCode": "javascript-401n17"
}
```

1. Define your inbound DTO
   - This is the same as defining an outbound data contract
   - Create a class in your `/Models/Api/` folder for the DTO
   - Identify the fields you'll be requiring
     - Note, that these can be nested, using Navigation Properties
   ```csharp
   public class NewStudentDto
   {
     [Required]
     public string Name { get; set; }
     public DateTime Dob { get; set; }
     public string CourseCode { get; set; }
   }
   ```
1. Change your Controller to require this on the incoming POST (or PUT)
   ```csharp
    [HttpPost]
    public async Task<ActionResult<Student>> PostStudent(NewStudentDto student)
    {
      Student newStudent = await _student.Create(student);
      return CreatedAtAction("GetStudent", new { id = newStudent.Id }, newStudent);
    }
   ```
1. Change your Service to use the DTO, and create the requisite database entries from it
   - Code this out iteratively, in steps
   ```csharp
   public async Task<Student> Create(NewStudentDto inboundData)
   {

     // Add the student
     Student student = new Student()
     {
       FirstName = inboundData.Name.Split(" ").First<string>(),
       LastName = inboundData.Name.Split(" ").Last<string>(),
       DateOfBirth = inboundData.Dob
     };

     _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Added;
     await _context.SaveChangesAsync();

     // Because we don't know the courseId, we have to find the course by name and then see the ID
     Course course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseCode == inboundData.CourseCode);

     // Add an enrollment for the student and course
     Enrollment enrollment = new Enrollment()
     {
       CourseId = course.Id,
       StudentId = student.Id
     };

     _context.Entry(enrollment).State = EntityState.Added;
     await _context.SaveChangesAsync();

     return student;
   }
   ```

That's fine for 'getting it to work', but this is a great opportunity to talk through making this method more of a "strategy" and instead of having it do everything, bring in the course service as a dependency, and offload the work to that service, where we not only already have code wired up, but where it belongs ...

1. Alter the Courses Service, adding the `GetOneByCourseCode` method
  - Why are we moving this to the Courses Service (Semantics)
  - Remember to add it to the `ICourses` interface!
   ```csharp
    public async Task<Course> GetOneByCourseCode(string courseCode)
    {
      return await _context.Courses.FirstOrDefaultAsync(s => s.CourseCode == courseCode);
    }
   ```
1. Inject the Course Service into the Student Service
   - Utilize Dependeny Injection to inject the Course Service
     - Reminder, the students controller knows it needs the students service. The service provider "sees" that it now has 2 params, and then locates & injects them for us
   - Make the following changes to your Student Service file, which identifies the new dependency and initializes it as `_courses`
   ```csharp
   public class StudentRepository : IStudent
   {
     private SchoolDbContext _context;
     private ICourse _courses;

     public StudentRepository(SchoolDbContext context, ICourse courseService)
     {
       _context = context;
       _courses = courseService;
     }
     ...
   ```
1. Given access to the Courses Service, we can now call on its methods to refactor the `Create` method
   - This allows to properly separate concerns (courses deal with their own enrollments and find methods)
   - This also allows us to revisit the Dependency Injection lifecycle
   ```csharp
   public async Task<Student> Create(NewStudentDto inboundData)
   {

     // Add the student
     Student student = new Student()
     {
       FirstName = inboundData.Name.Split(" ").First<string>(),
       LastName = inboundData.Name.Split(" ").Last<string>(),
       DateOfBirth = inboundData.Dob
     };

     _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Added;
     await _context.SaveChangesAsync();

     // Use the Courses Service to get a course from the course service
     Course course = await _courses.GetOneByCourseCode(inboundData.CourseCode);

     // Use the Courses Service to add an enrollment for the student and course
     await _courses.AddStudent(course.Id, student.Id);

     return student;
   }
   ```
