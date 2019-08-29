using Estacionamiento.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamiento.Context
{
    public class EstacionamientoDbContext : DbContext 
    {
        public EstacionamientoDbContext(DbContextOptions<EstacionamientoDbContext> option)
           :base(option)

        {

        }
        
        public DbSet<Plaza> Plazas { get; set; }
        public DbSet<Parking> Parkins { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


    }
}
