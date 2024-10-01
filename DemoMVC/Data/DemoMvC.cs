using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

    public class DemoMvC : DbContext
    {
        public DemoMvC (DbContextOptions<DemoMvC> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Person> Person { get; set; } = default!;
    }
