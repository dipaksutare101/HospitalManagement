using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagement.Core.Models;

namespace HospitalManagement.Core.Repositories
{
    public interface ISpecializationRepository
    {
        // Get Specialization  data
         IEnumerable<Specialization> GetSpecialization();
        
    }
}