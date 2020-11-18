using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week7tut.Models;

namespace Week7tut.Data
{
    public class Week7tutContext : DbContext
    {
        public Week7tutContext (DbContextOptions<Week7tutContext> options)
            : base(options)
        {
        }

        public DbSet<Week7tut.Models.Students> Students { get; set; }
    }
}
