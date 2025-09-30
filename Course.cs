public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; } // senere decimal
    public int? InstructorId { get; set; }
    public Instructor Instructor { get; set; }
}
