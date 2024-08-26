using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasKey(S => S.StudentID);
            student.Property(S => S.StudentID).UseIdentityColumn(1, 1);
            student.Property(S => S.Name).HasColumnType("varchar").HasMaxLength(50);
            student.Property(S => S.Salary).HasColumnType("money");
            student.Property(S => S.Address).HasMaxLength(50).HasDefaultValue("Cairo");
        }
    }
}
