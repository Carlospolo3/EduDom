using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.ViewModels.Attendance
{
    public class AttendanceViewModels
    {
        public int Id { get; set; }
        public int StudentID { get; set; }
        public DateTime Date { get; set; }
        public bool Presente { get; set; }
    }

}
