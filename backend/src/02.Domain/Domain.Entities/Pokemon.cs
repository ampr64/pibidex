using PibidexBackend.Entities.Base;
using System.Collections.Generic;

namespace PibidexBackend.Entities
{
    public class Pokemon : EntityBase<int>
    {
        public int GenerationId { get; set; }
        public int SpeciesId { get; set; }

        public string Description { get; set; }
        public decimal Height { get; set; }
        public string ImageUrl { get; set; }
        public decimal Weight { get; set; }

        public Generation Generation { get; set; }
        public IList<Type> Types { get; set; }
    }
}