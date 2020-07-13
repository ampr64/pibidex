﻿using System;

namespace Domain.Entities.Base
{
    public class EntityBase<TPrimaryKey> : IEntityBase<TPrimaryKey>
    {
        public TPrimaryKey Id { get; }
        public string Identifier { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}