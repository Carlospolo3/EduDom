using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationNumber { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string Email { get; set; }
        public string Telefono {  get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Attendance> Attendances { get; set; }
        public List<Reports> Reports { get; set; }
        public List<Qualifications> Qualifications { get; set; }
    }

}
