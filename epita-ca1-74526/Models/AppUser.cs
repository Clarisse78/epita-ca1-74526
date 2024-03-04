﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace epita_ca1_74526.Models
{
    public class AppUser : IdentityUser<int>
    {
        //[Key]
        //public int Id { get; set; }
      
        public string? firstName { get; set; }

        public string? lastName { get; set; }    
        public string? accountNumber { get; set; }

        public string? pin { get; set; }

    }
}
