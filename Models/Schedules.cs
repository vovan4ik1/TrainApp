namespace TrainApp.Models
{
    public class Schedules
    {
        public int Id { get; set; }

        public int TrainRouteId { get; set; }
        public Trains Train { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public int OriginStationId { get; set; }
        public Stations OriginStation { get; set; }

        public int DestinationStationId { get; set; }
        public DestinationStations DestinationStation { get; set; }

        public int DelayId { get; set; }
        public Delay Delays { get; set; }
    }
}
