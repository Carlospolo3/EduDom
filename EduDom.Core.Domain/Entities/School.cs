using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ProvinceId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Province Province { get; set; }
        public List<Department> Departments { get; set; }
        public List<Course> Courses { get; set; }
    }
}
