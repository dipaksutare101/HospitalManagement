using System.Data.Entity.ModelConfiguration;
using HospitalManagement.Core.Models;

namespace HospitalManagement.Persistence.EntityConfigurations
{
    public class PatientStatusConfiguration : EntityTypeConfiguration<PatientStatus>
    {
        public PatientStatusConfiguration()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(255);
        }
    }
}