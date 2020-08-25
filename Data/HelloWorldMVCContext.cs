using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldMVC.Models
{
    public class HelloWorldMVCContext : DbContext
    {
        public HelloWorldMVCContext (DbContextOptions<HelloWorldMVCContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldMVC.Models.Movie> Movie { get; set; }
    }
}
