using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class TeacherSchedule
    {
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public int MyProperty { get; set; }
    }
}
