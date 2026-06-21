namespace api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
        public int DepartmentId { get; set; }
        // Navigation property
        // allows you to cleanly access the parent entity Dept.Name
        public Department? Department { get; set; }
    }
}