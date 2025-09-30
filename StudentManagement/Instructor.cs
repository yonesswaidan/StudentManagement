using System;

namespace StudentManagement
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        // Relation til Courses
        public ICollection<Course> Courses { get; set; }
    }
}
