using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Class1
    {
        [Required(ErrorMessage ="Input required")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Between 3 and 20")]
        public string name { get; set; }
        [Required(ErrorMessage = "Input required")]
        [RegularExpression(@"^[\w\.\+\#]{3,}[@][a-z A-z]{3,}[\.][a-zA-Z]{3,}$",ErrorMessage ="Invalid Format")]
        public string email { get; set; }
        [Required(ErrorMessage = "Input required")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Invalid Type Password")]
        public string password { get; set; }
    }
}