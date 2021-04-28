using Fitos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fitosanitario> Fitosanitario { get; set; }
        public DbSet<Mezcla> Mezcla { get; set; }
        public DbSet<Mezclas> Mezclas { get; set; }
    }
}
