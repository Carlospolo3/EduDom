namespace EduDom.Core.Domain.Entities
{
    public class Employeer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string IdentificationNumber { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

}
