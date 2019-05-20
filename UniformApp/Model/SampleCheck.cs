using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class SampleCheck
    {
        private int _processOrderNo { get; set; }
        private TimeSpan _checkTime { get; set; }
        private int _employeeNo { get; set; }

        public int ProcessOrderNo
        {
            get => _processOrderNo;
            set => _processOrderNo = value;
        }

        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }

        public int EmployeeNo
        {
            get => _employeeNo;
            set => _employeeNo = value;
        }


        public SampleCheck(int processOrderNo, TimeSpan checkTime, bool sampleCheck, int employeeNo)
        {
            ProcessOrderNo = processOrderNo;
            CheckTime = checkTime;
            EmployeeNo = employeeNo;
        }

        public SampleCheck()
        {
            
        }
    }
}
