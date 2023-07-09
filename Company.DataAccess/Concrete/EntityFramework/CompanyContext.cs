using Company.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataAccess.Concrete.EntityFramework
{
    public class CompanyContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
