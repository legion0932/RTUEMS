using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RTUEMS.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RTUEMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {

        }
        public DbSet<RTUEMS.Models.Event> Event { get; set; } = default!;
        public object Events { get; internal set; }

        
    }
}