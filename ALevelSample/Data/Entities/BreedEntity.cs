using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevelSample.Data.Entities
{
    public class BreedEntity
    {
        public int Id { get; set; }

        public string BreedName { get; set; } = null!;

        public List<PetEntity> BreedItems { get; set; } = new List<PetEntity>();

        public CategoryEntity? Category { get; set; }

        public int CategoryId { get; set; }
    }
}
