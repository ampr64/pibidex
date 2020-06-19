using System;
using System.Collections.Generic;
using System.Text;

namespace PibidexBackend.Entities
{
    public class Region : EntityBase<int>
    {
        public string Name { get; set; }
        public Generation Generation { get; set; }
    }
}