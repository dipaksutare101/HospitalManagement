using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories;
namespace HospitalManagement.Persistence.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext _context;
        public DoctorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}