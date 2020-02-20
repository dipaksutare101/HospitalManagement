using System.Data.Entity.ModelConfiguration;
using HospitalManagement.Core.Models;

namespace HospitalManagement.Persistence.EntityConfigurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}