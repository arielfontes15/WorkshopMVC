using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkshopMVC.Models;

namespace WorkshopMVC.Data
{
    public class WorkshopMVCContext : DbContext
    {
        public WorkshopMVCContext (DbContextOptions<WorkshopMVCContext> options)
            : base(options)
        {

        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<VendaRecorde> VendaRecorde { get; set; }
    }
}
