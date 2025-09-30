using System;

namespace StudentManagement
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        // Relation til DepartmentHead (Instructor)
        public int? DepartmentHeadId { get; set; }
        public Instructor DepartmentHead { get; set; }
    }
}
