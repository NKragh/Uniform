using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class TorqueCheck
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private double _preformTemp;
        private double _torque;
        private int _employeeNo;
        private int _lidNo;
        private int _preformNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public double PreformTemp { get => _preformTemp; set => _preformTemp = value; }
        public double Torque { get => _torque; set => _torque = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int LidNo { get => _lidNo; set => _lidNo = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }

        public TorqueCheck(int processOderNo, TimeSpan checkTime, double preformTemp, double torque, int employeeNo, int lidNo, int preformNo)
        {
            ProcessOrderNo = processOderNo;
            CheckTime = checkTime;
            PreformTemp = preformTemp;
            Torque = torque;
            EmployeeNo = employeeNo;
            LidNo = lidNo;
            PreformNo = preformNo;
        }
        
        //Instantiating class without parameters
        public TorqueCheck()
        {

        }
    }
}
