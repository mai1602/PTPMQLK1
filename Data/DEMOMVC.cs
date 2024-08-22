using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

    public class DEMOMVC : DbContext
    {
        public DEMOMVC (DbContextOptions<DEMOMVC> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Person> Person { get; set; } = default!;
    }