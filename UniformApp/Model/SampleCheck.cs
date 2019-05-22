using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class SampleCheck
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProcessOrderNo">ProcessOrder number from ProcessOrder</param>
        /// <param name="Employee"> Employee number from Employee</param>
        private int _processOrderNo;

        private bool _sampleCheck;
        private TimeSpan _checkTime;
        private int _employeeNo; 

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

        public bool Check
        {
            get { return _sampleCheck; }
            set { _sampleCheck = value; }
        }


        public SampleCheck(int processOrderNo, TimeSpan checkTime, bool sampleCheck, int employeeNo)
        {
            ProcessOrderNo = processOrderNo;
            CheckTime = checkTime;
            Check = sampleCheck;
            EmployeeNo = employeeNo;
        }

        public SampleCheck()
        {
            
        }
    }
}
