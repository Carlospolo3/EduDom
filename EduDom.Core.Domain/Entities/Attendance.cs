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
        public int Students { get; set; }
        public DateTime Date { get; set; }
        public bool Presente { get; set; }
    }

}
