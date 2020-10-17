using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Domain.Model
{
    public class DoctorConactInformation
    {
        public int DoctorConactInformationId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int DoctorRef { get; set; }
        public Doctor Doctor { get; set; }
    }
}
