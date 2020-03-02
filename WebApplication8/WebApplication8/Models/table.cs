using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class table
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}