using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Core.Models;
namespace HospitalManagement.Core.Repositories
{
    public interface IDoctorRepository 
    {
        IEnumerable<Doctor> GetDoctors();
        void Add(Doctor doctor);
    }
}
