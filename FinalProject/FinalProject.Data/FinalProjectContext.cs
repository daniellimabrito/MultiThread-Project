using FinalProject.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace FinalProject.Data
{
    public class FinalProjectContext : DbContext
    {
        public DbSet<Operation> Operations { get; set; }

        public FinalProjectContext()
        {

        }

        public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
            : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = FinalProjectData; Trusted_Connection = True; ");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
