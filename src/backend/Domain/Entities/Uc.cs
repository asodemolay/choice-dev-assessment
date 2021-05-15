using System.Globalization;

namespace backend.Domain.Entities
{
    public class Uc
    {
        public long Id { get; private set; }
        public string ConsumerName { get; private set; }
        public Coordinate Coordinates { get; private set; }
        public Region Region { get; set; }
        public Locality Locality { get; set; }
        public Municipality Municipality { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public MeterType MeterType { get; set; }
        public UcClass UcClass { get; set; }
        public Phase Phase { get; set; }
        public ActivityField ActivityField { get; set; }
        public VoltageLevel VoltageLevel { get; set; }


        public Uc(string name)
        {
            ConsumerName = name;
        }
        public Uc(long id, string name, decimal longitude, decimal latitude, int idRegion, int idLocality, int idMunicipality,
            int idNeighborhood, int idUcMeterType, int idUcClass, int idUcPhase, int idUcActivityField, int idUcVoltageLevel)
        {
            Id = id;
            ConsumerName = name;
            Coordinates = new Coordinate(latitude, longitude);
            Region = new Region() { Id = idRegion};
            Locality = new Locality() { Id = idLocality };
            Municipality = new Municipality() { Id = idMunicipality };
            Neighborhood = new Neighborhood() { Id = idNeighborhood};
            MeterType = new MeterType() { Id = idUcMeterType };
            UcClass = new UcClass() { Id = idUcClass };
            Phase = new Phase() { Id = idUcPhase };
            ActivityField = new ActivityField() { Id = idUcActivityField };
            VoltageLevel = new VoltageLevel() { Id = idUcVoltageLevel };
        }

        public void SetCoordinates(long latitude, long longitude)
        {
            Coordinates = new Coordinate(latitude, longitude);
        }

        public static Uc FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Uc uc = new(
                id: long.Parse(values[0]),
                name: values[1],
               longitude: decimal.Parse(values[2], CultureInfo.InvariantCulture),
               latitude: decimal.Parse(values[3], CultureInfo.InvariantCulture),
               idRegion: int.Parse(values[4]),
               idLocality: int.Parse(values[5]),
               idMunicipality: int.Parse(values[6]),
               idNeighborhood: int.Parse(values[7]),
               idUcMeterType: int.Parse(values[8]),
               idUcClass: int.Parse(values[9]),
               idUcPhase: int.Parse(values[10]),
               idUcActivityField: int.Parse(values[11]),
               idUcVoltageLevel: int.Parse(values[12]));
            return uc;
        }
    }
}
