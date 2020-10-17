using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Domain.Model
{
    public class Visit
    {
        public int VisitId { get; set; }
        public string VistitName { get; set; }
        public string Date { get; set; }

        public int TypeId { get; set; }
        public virtual Type Type { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
