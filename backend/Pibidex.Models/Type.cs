using System;
using System.Collections.Generic;
using System.Text;

namespace PibidexBackend.Entities
{
    public class Type : EntityBase<int>
    {
        public string Name { get; set; }
    }
}