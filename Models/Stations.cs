using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace TrainApp.Models
{
    public class Stations
    {
        public int Id { get; set; }
        [Display(Name = "Назва станції")]
        public string StationName { get; set; }
        [Display(Name = "Регіон")]
        public string Region { get; set; }

        public ICollection<TrainRoute> TrainRoutes { get; }

    }
}
