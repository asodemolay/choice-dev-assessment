using backend.Domain.Entities;
using System.Collections.Generic;

namespace backend.Infra.Data.CSV
{
    public interface IContext
    {
        IEnumerable<Uc> Ucs { get; }
        IEnumerable<Region> Regions { get; }
        IEnumerable<Locality> Localities { get; }
        IEnumerable<Municipality> Municipalities { get; }
        IEnumerable<Neighborhood> Neighborhoods { get; }
        IEnumerable<MeterType> MeterTypes { get; }
        IEnumerable<UcClass> UcClasses { get; }
        IEnumerable<ActivityField> ActivityFields { get; }
        IEnumerable<Phase> Phases { get; }
        IEnumerable<VoltageLevel> VoltageLevels { get; }
    }
}
