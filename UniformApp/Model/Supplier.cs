using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class Supplier
    {
        private string _supplierName;

        public string SupplierName { get => _supplierName; set => _supplierName = value; }

        public Supplier(string supplierName)
        {
            _supplierName = supplierName;
        }
        public Supplier() { }
    }
}
