﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

    }
}
