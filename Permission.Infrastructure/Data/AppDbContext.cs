using Microsoft.EntityFrameworkCore;
using Permission.Core.Entities.EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TBLEmployeeEntity> TBLEmployeeEntity { get; set; }
    }
}
