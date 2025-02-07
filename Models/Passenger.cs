using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace TrainApp.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }

        [Phone]
        [Display(Name = "Номер телефону")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
