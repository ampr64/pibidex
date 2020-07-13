using Domain.Entities.Base;
using Domain.Entities.Relationship;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Group : EntityBase<int>
    {
        public IList<SpeciesGroup> SpeciesGroups { get; set; }
    }
}