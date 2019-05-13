using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class WeightCheck
    {
        private int _processNo;
        private DateTime _checkTime;
        private float _weight1;
        private float _weight2;
        private float _weight3;
        private float _weight4;
        private float _weight5;
        private float _weight6;
        private string _comments;
        private int _employeeNo;
        private int _productNo;

        public DateTime CheckTime
        {
            get { return DateTime.Now; }
            set { _checkTime = value; }
        }
    }
}
