using Appointments.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointments.API.Data
{
    public class AppointmentsDBContext : DbContext
    {
        public AppointmentsDBContext(DbContextOptions<AppointmentsDBContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Client client1 = new()
            {
                Id = Guid.Parse("62357129ff574a9aae9eae2856444fb7"),
                Name = "Bill",
                Phone = "555-555-1000",
                Email = "bill@gmail.com"
            };

            Client client2 = new()
            {
                Id = Guid.Parse("6af42834e99e4881affea4702014f59e"),
                Name = "Jeff",
                Phone = "555-555-2000",
                Email = "jeff@outlook.com"
            };

            modelBuilder.Entity<Client>().HasData(client1, client2);

            Doctor doctor1 = new()
            {
                Id = Guid.Parse("bfddfbc11f1d44778c0408f3f7237eb9"),
                Name = "Doctor1"
            };

            Doctor doctor2 = new()
            {
                Id = Guid.Parse("e3aec57ac9814949a4c10c2775cbfce9"),
                Name = "Doctor2"
            };

            modelBuilder.Entity<Doctor>().HasData(doctor1, doctor2);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Doctor> Doctor { get; set; } = default!;
        public DbSet<Client> Client { get; set; } = default!;
        public DbSet<Appointment> Appointment { get; set; } = default!;
    }
}
