using Employee_Login_JWT_API_11.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Login_JWT_API_11.Identity
{
  public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      :base(options) 
    {

    }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; } 
        protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }
  }
}
