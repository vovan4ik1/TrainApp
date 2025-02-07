using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TrainApp.Models
{
    public class TrainCrew
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Поїзд")]
        public int TrainId { get; set; }
        [ForeignKey("TrainId")]
        public Trains Train { get; set; }

        [Required]
        [Display(Name = "Роль")]
        public string Role { get; set; }

        [Required]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }
    }
}
