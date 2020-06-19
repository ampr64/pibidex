using System;
using System.Collections.Generic;
using System.Text;

namespace PibidexBackend.Entities
{
    public interface IEntityBase<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}