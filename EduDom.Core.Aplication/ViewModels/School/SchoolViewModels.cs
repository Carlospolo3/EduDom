﻿using EduDom.Core.Aplication.ViewModels.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduDom.Core.Domain.Entities
{
    public class SchoolViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ProvinceViewModels Province { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
