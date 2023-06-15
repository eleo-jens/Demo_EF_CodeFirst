using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DemoCodeFirstContext : DbContext
    {
        public DemoCodeFirstContext(DbContextOptionsBuilder optionsBuilder) : base(optionsBuilder.Options) {

            string connectionString = "Data Source=ELEC-02;Initial Catalog=ModelFirst;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

        }

        public virtual DbSet<Role> Roles { get; set; }
    }
}
