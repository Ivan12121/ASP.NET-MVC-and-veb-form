using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prak7MVC.Models
{
    public class AllContext : DbContext
    {
        public DbSet<Guests> guests { get; set; }
    }
}