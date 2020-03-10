using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagement.Core;
using HospitalManagement.Core.Repositories;
using HospitalManagement.Persistence.Repositories;
namespace HospitalManagement.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApplicationDbContext _context;
        public ISpecializationRepository Specializations { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Specializations = new SpecializationRepository(context);
        }

         

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}