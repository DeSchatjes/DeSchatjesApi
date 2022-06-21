using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeSchatjesApi.Models;

namespace DeSchatjesApi.Data
{
    public class DeSchatjesApiContext : DbContext
    {
        public DeSchatjesApiContext (DbContextOptions<DeSchatjesApiContext> options)
            : base(options)
        {
        }

        public DbSet<DeSchatjesApi.Models.Event>? Event { get; set; }
    }
}
