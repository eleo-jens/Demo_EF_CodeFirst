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
        public DemoCodeFirstContext(DbContextOptions options) : base(options) {

        }

        public virtual DbSet<Role> Roles { get; set; }
    }
}
