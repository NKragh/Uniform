using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class Preform
    {
        private int _preformNo;
        private int _size;
        private double _weight;
        private double _minValue;
        private double _maxValue;
        private string _supplierName;

        public int PreformNo { get => _preformNo; set => _preformNo = value; }
        public int Size { get => _size; set => _size = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public string SupplierName { get; set; }

        public Preform(int preformNo, int size, double weight, double minValue, double maxValue, string supplierName)
        {
            PreformNo = preformNo;
            Size = size;
            Weight = weight;
            MinValue = minValue;
            MaxValue = maxValue;
            SupplierName = supplierName;
        }

        public Preform() { }
    }
}
