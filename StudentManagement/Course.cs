using System.Collections.Generic;

namespace StudentManagement
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Credits { get; set; }  // decimal(5,2)

        // Relation til Instructor
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        // Relation til Enrollments
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
