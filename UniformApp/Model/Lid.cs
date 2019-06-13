using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class Lid
    {
        private int _lidNo;
        private double _minValue;
        private double _midValue;
        private double _maxValue;
        public int LidNo { get => _lidNo; set => _lidNo = value; }
        public double MinValue { get => _minValue; set => _minValue = value; }
        public double MidValue { get => _midValue; set => _midValue = value; }
        public double MaxValue { get => _maxValue; set => _maxValue = value; }

        public Lid(int lidNo, double minValue, double midValue, double maxValue)
        {
            LidNo = lidNo;
            MinValue = minValue;
            MidValue = midValue;
            MaxValue = maxValue;
        }
        public Lid()
        {
            
        }
    }
}
