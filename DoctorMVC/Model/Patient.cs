using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Domain.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public long PESEL { get; set; }

        public virtual ICollection<Visit> Visit { get; set; }
    }
}
