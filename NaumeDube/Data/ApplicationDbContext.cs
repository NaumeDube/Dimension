using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NaumeDube.Models;

namespace NaumeDube.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NaumeDube.Models.Company> Company { get; set; }
        public DbSet<NaumeDube.Models.Department> Department { get; set; }
        public DbSet<NaumeDube.Models.Employee> Employee { get; set; }
        public DbSet<NaumeDube.Models.Job> Job { get; set; }
        public DbSet<NaumeDube.Models.Payment> Payment { get; set; }
        public DbSet<NaumeDube.Models.Work> Work { get; set; }
    }
}
