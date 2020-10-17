﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Domain.Model
{
    public class Type
    {
        public int TypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
