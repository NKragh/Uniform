using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class Product
    {
        private int _productNo;
        private string _productName;
        private bool _sugar;
        private string _fluidCode;
        private float _minValue;
        private float _midValue;
        private float _maxValue;

        public int ProductNo { get => _productNo; set => _productNo = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public bool Sugar { get => _sugar; set => _sugar = value; }
        public string FluidCode { get => _fluidCode; set => _fluidCode = value; }
        public float MinValue { get => _minValue; set => _minValue = value; }
        public float MidValue { get => _midValue; set => _midValue = value; }
        public float MaxValue { get => _maxValue; set => _maxValue = value; }

        public Product(int productNo, string productName, bool sugar, string fluidCode, float minValue, float midValue, float maxValue)
        {
            ProductNo = productNo;
            ProductName = productName;
            Sugar = sugar;
            FluidCode = fluidCode;
            MinValue = minValue;
            MidValue = midValue;
            MaxValue = maxValue;
        }

        public Product()
        {
            
        }
    }
}
