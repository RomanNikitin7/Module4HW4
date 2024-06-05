using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevelSample.Data.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; } = null!;

        public List<PetEntity> CategoryItems { get; set; } = new List<PetEntity>();

        public List<BreedEntity> CategoryBreedItems { get; set; } = new List<BreedEntity>();
    }
}
