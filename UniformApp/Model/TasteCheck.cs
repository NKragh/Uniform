using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class TasteCheck : ICheckable
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private int _tankNo;
        private bool _tasteOk;
        private int _employeeNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public int TankNo { get => _tankNo; set => _tankNo = value; }
        public bool TasteOk { get => _tasteOk; set => _tasteOk = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }

        public TasteCheck(int processOrderNo, TimeSpan checkTime, int tankNo, bool tasteOk, int employeeNo)
        {
            _processOrderNo = processOrderNo;
            _checkTime = checkTime;
            _tankNo = tankNo;
            _tasteOk = tasteOk;
            _employeeNo = employeeNo;
        }

       public TasteCheck()
        {

        } 
    }
}
