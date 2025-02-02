﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public Boolean Active { get; set; }

        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
