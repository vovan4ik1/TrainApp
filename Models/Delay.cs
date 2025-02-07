using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrainApp.Models
{
    public class Delay
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Розклад")]
        public int ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public ICollection<Schedules> Schedule { get; set; }

        [Display(Name = "Причина затримки")]
        public string DelayReason { get; set; }

        [Required]
        [Display(Name = "Тривалість затримки (хвилин)")]
        public int DelayDuration { get; set; }
    }
}
