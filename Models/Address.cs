using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace mvc.Models
{
    //this is a POCO class
    //it represents the Address table in the database
    public class Address
    {
        [Key]       // make this Id as primary key
        public int Id { get; set; }
        public string Street {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        
    }
}