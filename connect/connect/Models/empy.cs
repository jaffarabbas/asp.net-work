using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace connect.Models
{
    public class empy
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}