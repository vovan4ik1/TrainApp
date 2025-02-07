using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrainApp.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Розклад")]
        public int ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public virtual Schedules Schedule { get; set; }

        [Required]
        [Display(Name = "Пасажир")]
        public int PassengerId { get; set; }
        [ForeignKey("PassengerId")]
        public virtual Passenger Passenger { get; set; }

        [Display(Name = "Номер місця")]
        public string SeatNumber { get; set; }

        [Required]
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }
    }
}
