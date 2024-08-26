using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> dept)
        {
            dept.HasKey(D => D.DepartmentID);
            dept.Property(D => D.DepartmentID).UseIdentityColumn(10, 10);
        }
    }
}
