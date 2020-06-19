using System;
using System.Collections.Generic;
using System.Text;

namespace PibidexBackend.Entities
{
    public class Generation : EntityBase<string>
    {
        public Region Region { get; set; }
    }
}