using DoctorMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorMVC.Domain.Interfaces
{
    public interface IPatientRepository
    {
        int AddPatient(Patient patient);

        void DeletePatient(int patientId);

        int UpdatePatient(Patient patient);

        IQueryable<Visit> GetVisitsByPatientId(int patientId);

        IQueryable<Visit> GetVisitsByTypeId(int typeId);

        Visit GetVisitById(int visitId);

        IQueryable<Patient> GetPatientsByTypeId(int typeId);

        IQueryable<Patient> GetAllPatients();
    }
}
