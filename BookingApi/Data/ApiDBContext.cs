using BookingApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Data
{
    public class ApiDBContext:DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options)
        : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
    }
}
