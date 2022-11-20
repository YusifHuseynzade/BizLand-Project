using BizLand_21._11._2022.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BizLand_21._11._2022.DAL
{
    public class BizLandTablesDbContext : DbContext
    {
        public BizLandTablesDbContext(DbContextOptions<BizLandTablesDbContext> options) : base(options)
        {

        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
