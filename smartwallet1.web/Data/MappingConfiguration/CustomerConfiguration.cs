using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data.MappingConfiguration
{
    public static class CustomerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("First_Name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100).HasColumnName("Last_Name");
            modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Address).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.PhoneNumber).IsRequired(true).HasMaxLength(11);
            modelBuilder.Entity<Customer>().Property(c => c.BirthDate).IsRequired(true);


            modelBuilder.Entity<Customer>().HasIndex(c => c.PhoneNumber).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();
            
            return modelBuilder;


        }

  
        }
    }

