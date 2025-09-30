namespace StudentManagement
{
    public class Enrollment
    {
        public int Id { get; set; }

        // Relation til Student
        public int StudentId { get; set; }
        public Student Student { get; set; }

        // Relation til Course
        public int CourseId { get; set; }
        public Course Course { get; set; }

        // Grade
        public int FinalGrade { get; set; }  // renamed from Grade
    }
}
