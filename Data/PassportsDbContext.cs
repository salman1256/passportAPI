using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PassportAPI.Models;

namespace PassportAPI.Data
{
    public class PassportsDbContext : DbContext
    {
        public PassportsDbContext (DbContextOptions<PassportsDbContext> options)
            : base(options)
        {
        }

        public DbSet<PassportAPI.Models.Passport> Passport { get; set; } = default!;
    }
}
