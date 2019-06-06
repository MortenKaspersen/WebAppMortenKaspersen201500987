using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Sensor
    {
        public int Id { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [Display(Name = "Tree species")]
        public string TreeSpecies { get; set; }

        [Display(Name = "Sensor Id")]
        public string SensorId { get; set; }

        [Display(Name = "Longitude")]
        public double GpsLongitude { get; set; }

        [Display(Name = "Latitude")]
        public double GpsLatitude { get; set; }

        //AspNetUsers table - UserName
        public string UserName { get; set; }


    }
}
