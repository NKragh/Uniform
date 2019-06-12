using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class Label
    {
        private int _labelNo;
        private int _productNo;

        public int LabelNo { get => _labelNo; set => _labelNo = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }

        public Label(int labelNo, int product)
        {
            _labelNo = labelNo;
            _productNo = product;
        }
        public Label() { }
    }
}
