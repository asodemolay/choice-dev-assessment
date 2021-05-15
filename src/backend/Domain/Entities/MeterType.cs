using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Domain.Entities
{
    public class MeterType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static MeterType FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            MeterType obj = new()
            {
                Id = int.Parse(values[0]),
                Name = values[1],
                Description = values[2]
            };
            return obj;
        }
    }
}
