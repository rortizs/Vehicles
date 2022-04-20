using Microsoft.EntityFrameworkCore;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //las tablas deben tener una propiedad DbSet
        public DbSet<VehicleType> VehicleTypes { get; set; }

        //sobre escribir el metodo 
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            //expresion lamba para indicar como unico la descripcion de la entidad
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
        }
    }
}
