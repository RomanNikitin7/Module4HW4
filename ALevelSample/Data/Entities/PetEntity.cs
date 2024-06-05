using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevelSample.Data.Entities
{
    public class PetEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public CategoryEntity? Category { get; set; }

        public BreedEntity? Breed { get; set; }

        public float Age { get; set; }

        public LocationEntity? Location { get; set; }

        public int CategoryId { get; set; }

        public int BreedId { get; set; }

        public int LocationId { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
