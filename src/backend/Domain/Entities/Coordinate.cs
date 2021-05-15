namespace backend.Domain.Entities
{
    public class Coordinate
    {
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }

        public Coordinate(decimal lat, decimal longi)
        {
            Latitude = lat;
            Longitude = longi;
        }
    }
}