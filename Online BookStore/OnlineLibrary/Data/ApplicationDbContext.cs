using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

          public DbSet<OnlineLibrary.Models.Book> Book { get; set; }
        public DbSet<OnlineLibrary.Models.Author> Author { get; set; }
        public DbSet<OnlineLibrary.Models.Genre> Genre { get; set; }
    }
}
