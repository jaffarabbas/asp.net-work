using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class connect:DbContext
    {
        public DbSet<table>mady{ get; set; }
    }
}