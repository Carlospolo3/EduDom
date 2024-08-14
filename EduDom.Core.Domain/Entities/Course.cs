namespace EduDom.Core.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Student> Students { get; set; }
        public List<Schedule> Schedules { get; set; }
    }

}
