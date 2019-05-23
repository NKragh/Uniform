using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class SampleCheck : ICheckable
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private bool _sampleCheck;
        private int _employeeNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public bool Check { get => _sampleCheck; set => _sampleCheck = Boolean.Parse(value.ToString()); }

        public SampleCheck(int processOrderNo, TimeSpan checkTime, string sampleCheck, int employeeNo)
        {
            _processOrderNo = processOrderNo;
            _checkTime = checkTime;
            _sampleCheck = Boolean.Parse(sampleCheck);
            _employeeNo= employeeNo;
        }

        public SampleCheck()
        {
        }
    }
}
