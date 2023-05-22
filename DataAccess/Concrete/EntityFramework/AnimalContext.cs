using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class AnimalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-841VLQD0;Database=AnimalProject;Trusted_Connection=True;");

        }

        //Hangi nesnem hangisine karsilik geliyor onu belirtiyoruz.
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
