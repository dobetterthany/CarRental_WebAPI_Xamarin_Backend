using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental_WebAPI_Xamarin_Backend.Models
{
    public class Car_Details
    {
        [Key]
        public string RegNumber { get; set; }
        public string Car_Maker { get; set; }
        public string Car_Model { get; set; }
        public int Car_Mileage { get; set; }
    }
}
