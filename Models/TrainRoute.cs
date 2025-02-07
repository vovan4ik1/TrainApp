using System.ComponentModel.DataAnnotations.Schema;

namespace TrainApp.Models
{
    public class TrainRoute
    {
        public int Id { get; set; }

        public int TrainId { get; set; }
        public Trains Train { get; set; }

        public int OriginStationId { get; set; }
        public Stations OriginStation { get; set; }

        public int DestinationStationId { get; set; }
        public DestinationStations DestinationStation { get; set; }
    }
}
