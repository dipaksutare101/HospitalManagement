using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories;
using System.Data.Entity;

namespace HospitalManagement.Persistence.Repositories
{
    public class SpecializationRepository : ISpecializationRepository
    {
        public readonly ApplicationDbContext Context;
        public SpecializationRepository(ApplicationDbContext context)
        {
            Context = context;
        }
        public IEnumerable<Specialization> GetSpecialization()
        {
                return Context.Specializations.ToList();    
        }
    }
}