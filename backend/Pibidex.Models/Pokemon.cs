using System;
using System.Collections.Generic;

namespace PibidexBackend.Entities
{
    public class Pokemon : EntityBase<int>
    {
        public string Description { get; set; }
        public string Evolution { get; set; }
        public string Height { get; set; }
        public string ImageUrl { get; set; }
        public bool IsStarter { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
     
        public virtual Category Categories { get; set; }
        public virtual List<Type> Types { get; set; }
    }
}