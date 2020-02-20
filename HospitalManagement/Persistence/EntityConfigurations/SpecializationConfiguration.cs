using System.Data.Entity.ModelConfiguration;
using HospitalManagement.Core.Models;

namespace HospitalManagement.Persistence.EntityConfigurations
{
    public class SpecializationConfiguration : EntityTypeConfiguration<Specialization>
    {
        public SpecializationConfiguration()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(255);
        }
    }
}