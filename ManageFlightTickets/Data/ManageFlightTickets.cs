using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManageFlightTickets.Models;

namespace ManageFlightTickets.Data
{
    public class ManageFlightTicketsContext : DbContext
    {
        public ManageFlightTicketsContext (DbContextOptions<ManageFlightTicketsContext> options)
            : base(options)
        {
        }

        public DbSet<ManageFlightTickets.Models.Account> Account { get; set; } = default!;
    }
}
