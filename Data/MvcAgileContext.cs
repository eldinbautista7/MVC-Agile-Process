using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Agile_Process.Models;

    public class MvcAgileContext : DbContext
    {
        public MvcAgileContext (DbContextOptions<MvcAgileContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Agile_Process.Models.Movie> Movie { get; set; } = default!;
    }
