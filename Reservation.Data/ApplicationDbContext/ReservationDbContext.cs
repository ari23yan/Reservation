using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Reservation.Domain.Entities.Account;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Data.ApplicationDbContext
{
    public class ReservationDbContext: DbContext
    {
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
     
    }
}
