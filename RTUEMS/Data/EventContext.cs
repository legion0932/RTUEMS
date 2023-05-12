using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RTUEMS.Models;

namespace RTUEMS.Data
{
    public class EventContext : DbContext
    {
        public EventContext (DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<RTUEMS.Models.Event> Event { get; set; } = default!;
        public object Events { get; internal set; }
        public DbSet<RTUEMS.Models.Member> Member { get; set; } = default!;
    }
}
