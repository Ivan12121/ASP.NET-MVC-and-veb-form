﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prak3AspMVC.Models
{
    public class Customers
    {
        [Key]
        public int Id_customers { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public int Id_orders { get; set; }
    }
}