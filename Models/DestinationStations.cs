namespace TrainApp.Models
{
    public class DestinationStations
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public string Region { get; set; }

        public ICollection<TrainRoute> DestinationRoutes { get; set; }
    }
}
