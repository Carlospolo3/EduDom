using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class Logins
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime AttemptDate { get; set; }
        public bool IsSuccessful { get; set; }

    }
}
