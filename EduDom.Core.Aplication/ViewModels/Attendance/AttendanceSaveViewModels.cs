using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Aplication.ViewModels.Attendance
{
    public class AttendanceSaveViewModels
    {
        public int Id { get; set; }
        public int Students { get; set; }
        public DateTime Date { get; set; }
        public bool Presente { get; set; }
    }

}
