using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; } // INT ile uyumlu
        public int? CategoryId { get; set; } // INT (nullable)
        public int? SupplierId { get; set; } // INT (nullable)
        public string ProductName { get; set; } // NVARCHAR
        public string QuantityPerUnit { get; set; } // NVARCHAR
        public decimal UnitPrice { get; set; } // MONEY
        public short UnitsInStock { get; set; } // SMALLINT
        public short UnitsOnOrder { get; set; } // SMALLINT
        public short ReorderLevel { get; set; } // SMALLINT
        public bool Discontinued { get; set; } // BIT
    }


}
