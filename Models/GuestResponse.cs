using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your age.")]
        public string? guestAge { get; set; }

        [Required(ErrorMessage = "Please enter your arrival time.")]
        [DataType(DataType.Time)]
        public DateTime? arrivalTime { get; set; }

        [Required(ErrorMessage = "Please specify whether you require parking assistance.")]
        public bool? requestParking { get; set; }
    }
}
