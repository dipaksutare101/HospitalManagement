using HospitalManagement.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Core
{
   public  interface IUnitOfWork
    {

        ISpecializationRepository Specializations { get; }
        IDoctorRepository Doctors { get; }

        void Complete();
    }
}
