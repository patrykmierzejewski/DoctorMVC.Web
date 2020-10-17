using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Domain.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorCode { get; set; }

        public DoctorConactInformation doctorConact { get; set; }
    }
}
