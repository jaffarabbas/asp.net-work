using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web; 

namespace connect.Models
{
    public class main:DbContext
    {
        public DbSet<empy>Objk{ get; set; }
    }
}