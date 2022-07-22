using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ZoomCars.Models
{
    public partial class Car
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
        }

        public int Vin { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int? CarSeats { get; set; }
        public string CarType { get; set; }
        public string CarAvailable { get; set; }

        [Display(Name = "Total")]
        public int? CarPrice { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
