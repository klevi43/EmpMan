namespace api.Dtos
{
     public class CreateEmployeeRequestDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public int DepartmentId { get; set; }
    }
}