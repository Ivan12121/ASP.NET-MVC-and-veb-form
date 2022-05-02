using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prak7MVC.Models
{
    public class Guests
    {
        [Key]
        public int Id_guest { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string  confirm { get; set; }
    }
}