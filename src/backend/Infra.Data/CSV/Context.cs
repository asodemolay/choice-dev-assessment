using backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Infra.Data.CSV
{
    public class Context : IContext
    {
        const string UC_PATH = @"sample_data\UCS.csv";
        const string REGIONS_PATH = @"sample_data\REGIONS.csv";
        const string LOCALITIES_PATH = @"sample_data\LOCALITIES.csv";
        const string MUNICIPALITIES_PATH = @"sample_data\MUNICIPALITIES.csv";
        const string NEIGHBORHOODS_PATH = @"sample_data\NEIGHBORHOODS.csv";
        const string METER_TYPES_PATH = @"sample_data\UC_METER_TYPES.csv";
        const string UC_CLASSES_PATH = @"sample_data\UC_CLASSES.csv";
        const string ACTIVITY_FIELDS_PATH = @"sample_data\UC_ACTIVITY_FIELDS.csv";
        const string PHASES_PATH = @"sample_data\UC_PHASES.csv";
        const string VOLTAGE_LEVEL_PATH = @"sample_data\UC_VOLTAGE_LEVELS.csv";

        public Context()
        {
            string path = Directory.GetCurrentDirectory();
            Regions = File.ReadAllLines($@"{path}\{REGIONS_PATH}")
                        .Skip(1)
                        .Select(l => Region.FromCsv(l))
                        .ToList();

            Localities = File.ReadAllLines($@"{path}\{LOCALITIES_PATH}")
                        .Skip(1)
                        .Select(l => Locality.FromCsv(l))
                        .ToList();

            Municipalities = File.ReadAllLines($@"{path}\{MUNICIPALITIES_PATH}")
                        .Skip(1)
                        .Select(l => Municipality.FromCsv(l))
                        .ToList();

            Neighborhoods = File.ReadAllLines($@"{path}\{NEIGHBORHOODS_PATH}")
                        .Skip(1)
                        .Select(l => Neighborhood.FromCsv(l))
                        .ToList();

            MeterTypes = File.ReadAllLines($@"{path}\{METER_TYPES_PATH}")
                        .Skip(1)
                        .Select(l => MeterType.FromCsv(l))
                        .ToList();

            UcClasses = File.ReadAllLines($@"{path}\{UC_CLASSES_PATH}")
                        .Skip(1)
                        .Select(l => UcClass.FromCsv(l))
                        .ToList();

            ActivityFields = File.ReadAllLines($@"{path}\{ACTIVITY_FIELDS_PATH}")
                        .Skip(1)
                        .Select(l => ActivityField.FromCsv(l))
                        .ToList();

            Phases = File.ReadAllLines($@"{path}\{PHASES_PATH }")
                        .Skip(1)
                        .Select(l => Phase.FromCsv(l))
                        .ToList();

            VoltageLevels = File.ReadAllLines($@"{path}\{VOLTAGE_LEVEL_PATH }")
                        .Skip(1)
                        .Select(l => VoltageLevel.FromCsv(l))
                        .ToList();

            Ucs = File.ReadAllLines($@"{path}\{UC_PATH}")
                        .Skip(1)
                        .Take(100000)
                        .Select(l =>
                        {
                            var ucObject = Uc.FromCsv(l);
                            ucObject.Region = Regions.First(s => s.Id == ucObject.Region.Id);
                            ucObject.Locality = Localities.First(s => s.Id == ucObject.Locality.Id);
                            ucObject.Municipality = Municipalities.First(s => s.Id == ucObject.Municipality.Id);
                            ucObject.Neighborhood = Neighborhoods.First(s => s.Id == ucObject.Neighborhood.Id);
                            ucObject.MeterType = MeterTypes.First(s => s.Id == ucObject.MeterType.Id);
                            ucObject.UcClass = UcClasses.First(s => s.Id == ucObject.UcClass.Id);
                            ucObject.Phase = Phases.First(s => s.Id == ucObject.Phase.Id);
                            ucObject.ActivityField = ActivityFields.First(s => s.Id == ucObject.ActivityField.Id);
                            ucObject.VoltageLevel = VoltageLevels.First(s => s.Id == ucObject.VoltageLevel.Id);
                            return ucObject;
                        })
                        .ToList();
        }

        public IEnumerable<Uc> Ucs { get; private set; }

        public IEnumerable<Region> Regions { get; private set; }

        public IEnumerable<Locality> Localities { get; private set; }

        public IEnumerable<Municipality> Municipalities { get; private set; }

        public IEnumerable<Neighborhood> Neighborhoods { get; private set; }

        public IEnumerable<MeterType> MeterTypes { get; private set; }

        public IEnumerable<UcClass> UcClasses { get; private set; }

        public IEnumerable<ActivityField> ActivityFields { get; private set; }

        public IEnumerable<Phase> Phases { get; private set; }

        public IEnumerable<VoltageLevel> VoltageLevels { get; private set; }
    }
}
