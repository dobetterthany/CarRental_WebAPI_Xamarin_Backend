using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental_WebAPI_Xamarin_Backend.Models
{
    public class Customer
    {
        [Key]
        public string UserName { get; set; }
        public string Cust_Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
