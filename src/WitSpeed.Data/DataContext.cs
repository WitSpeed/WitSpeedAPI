using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WitSpeed.Models.Models;

namespace WitSpeed.Data
{
    public class DataContext: IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<DispatchTool> DispatchTools { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
    }
}
