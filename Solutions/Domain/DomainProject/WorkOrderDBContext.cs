using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DomainProject.DomainObjects;

namespace DomainProject
{
    public class WorkOrderDbContext : DbContext
    {
        public WorkOrderDbContext(DbContextOptions<WorkOrderDbContext> options)
            :base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientLocation> ClientLocations { get; set; }
    }
}
