using System;
using System.Collections.Generic;
using System.Text;

namespace PibidexBackend.Entities
{
    public class Category : EntityBase<int>
    {
        public string Name { get; set; }
    }
}