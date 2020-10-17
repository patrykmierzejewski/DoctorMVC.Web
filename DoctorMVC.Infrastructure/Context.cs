using DoctorMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Infrastructure
{
    public class Context : IdentityDbContext    
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<DoctorConactInformation> DoctorContactInformations { get; set; }
        public DbSet<Domain.Model.Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //relacja 1 do wielu - nie jest wymagana, załatwi to entity core.
            //pacjent - wiele wizyt, jedna konkretna wizyta - jeden pacjent.


            //relacja 1=1
            builder.Entity<Doctor>()
                .HasOne(x => x.doctorConact).WithOne(y => y.Doctor)
                .HasForeignKey<DoctorConactInformation>(z => z.DoctorRef);
        }
    }
}
