using System;
using System.Collections.Generic;
using System.Text;

namespace PibidexBackend.Entities.Base
{
    public class EntityBase<TPrimaryKey> : IEntityBase<TPrimaryKey>
    {
        public TPrimaryKey Id { get; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}