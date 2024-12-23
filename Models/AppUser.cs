// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace mvc.Models
{
    public class AppUser 
    {
        [Key]
        public string Id { get; set; }
        public Address? Address { get; set; }
        public int? Pace { get; set; }

        public int? Melga { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Race { get; set; }
    }
}