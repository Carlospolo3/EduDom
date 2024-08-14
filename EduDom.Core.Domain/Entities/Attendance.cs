using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public bool isPresent { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }

}
