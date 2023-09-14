using BasicBackendProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
