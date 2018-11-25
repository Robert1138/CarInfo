using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class VehiclesContext : DbContext
    {

        public VehiclesContext(DbContextOptions<VehiclesContext> options) : base(options)
        {

        }

        public DbSet<vehiclesFEGOV> Vehicles { get; set; }
        public DbSet<UserCar> UserCars { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
