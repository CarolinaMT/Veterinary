using Microsoft.EntityFrameworkCore;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }

        //Todos los indices los ponemos desde aqui
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //El campo que se va a repetir seria firstname
            //Le pone un indices al campo firsname y digale que es unico
            modelBuilder.Entity<Owner>().HasIndex(c => c.FirstName).IsUnique();
        }

    }
}
