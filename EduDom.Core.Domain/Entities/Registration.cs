namespace EduDom.Core.Domain.Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

}
