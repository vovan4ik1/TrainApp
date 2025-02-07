namespace TrainApp.Models
{
    public class Trains
    {
        public int Id { get; set; }
        public string TrainName { get; set; }
        public string TrainType { get; set; }

        public ICollection<TrainRoute> TrainRoutes { get; set; }
    }
}
