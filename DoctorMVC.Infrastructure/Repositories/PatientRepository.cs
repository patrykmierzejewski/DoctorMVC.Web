using DoctorMVC.Domain.Interfaces;
using DoctorMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorMVC.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly Context _context;
        public PatientRepository(Context context)
        {
            _context = context;
        }

        public int AddPatient(Patient patient)
        {
            _context.Add(patient);
            _context.SaveChanges();

            return patient.PatientId;
        }

        public void DeletePatient(int patientId)
        {
            var patient = _context.Patients.Find(patientId);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges(); // zasada tranzakcji- jezeli wszystko ok to ok, jezeli nei to rollback
            }
        }

        public int UpdatePatient(Patient patient)
        {
            _context.Update(patient);
            _context.SaveChanges();

            return patient.PatientId;
        }

        public IQueryable<Visit> GetVisitsByPatientId(int patientId)
        {
            IQueryable<Visit> visits = _context.Visits.Where(i => i.PatientId == patientId);
            return visits;
        }

        public IQueryable<Visit> GetVisitsByTypeId(int typeId)
        {
            var visits = _context.Visits.Where(i => i.TypeId == typeId);
            return visits;
        }
        public Visit GetVisitById(int visitId)
        {
            var visit = _context.Visits.FirstOrDefault(i => i.VisitId == visitId);
            return visit;
        }

        public IQueryable<Patient> GetPatientsByTypeId(int typeId)
        {
            var visits = GetVisitById(typeId);
            var patients = _context.Patients.Where(x => x.Visit == visits);

            return patients;
        }

        public IQueryable<Patient> GetAllPatients()
        {
            var patients = _context.Patients;
            return patients;
        }
    }
}
