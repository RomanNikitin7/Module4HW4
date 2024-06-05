using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevelSample.Data.Entities
{
    public class LocationEntity
    {
        public int Id { get; set; }

        public string LocationName { get; set; } = null!;

        public List<PetEntity> LocationItems { get; set; } = new List<PetEntity>();
    }
}
