using System;
using System.ComponentModel.DataAnnotations;


namespace TravelAPI.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }

        [Required]
        public string CountryName { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Rate must be a number between 1 and 5")]
        public int RateReview { get; set; }

    }
}