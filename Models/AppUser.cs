using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace mvc.Models
{
    public class AppUser 
    {
        public Address? Address { get; set; }
        public int? Pace { get; set; }

        public int? Melga { get; set; }
    }
}