using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Common;

namespace UniformApp.Model
{
    class TorqueCheck : ICheckable
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private float _preformTemp;
        private int _employeeNo;
        private int _lidNo;
        private int _preformNo;
        private float _torque;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public float PreformTemp { get => _preformTemp; set => _preformTemp = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int LidNo { get => _lidNo; set => _lidNo = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }
        public float Torque { get => _torque; set => _torque = value; }

        public TorqueCheck(int processOrderNo, TimeSpan checkTime, float preformTemp, int employeeNo, int lidNo, int preformNo, float torque)
        {
            _processOrderNo = processOrderNo;
            _checkTime = checkTime;
            _preformTemp = preformTemp;
            _employeeNo = employeeNo;
            _lidNo = lidNo;
            _preformNo = preformNo;
            _torque = torque;
        }

        public TorqueCheck()
        {
        }
    }
}
