using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRental_WebAPI_Xamarin_Backend.Models;

namespace CarRental_WebAPI_Xamarin_Backend.Data
{
    public class CarRental_Database : DbContext
    {
        public CarRental_Database (DbContextOptions<CarRental_Database> options)
            : base(options)
        {
        }

        public DbSet<CarRental_WebAPI_Xamarin_Backend.Models.Car_Details> Car_Details { get; set; }

        public DbSet<CarRental_WebAPI_Xamarin_Backend.Models.Customer> Customer { get; set; }
    }
}
