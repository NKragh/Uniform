using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class PressureCheck
    {
        private int _processOrderNo;
        private DateTime _checkTime;
        private int _formNo;
        private int _bar;
        private string _breakPoint;
        private int _employeeNo;
        private int _preformNo;

        /// <summary>
        /// User stories hertil; Som operatør vil jeg kunne indtaste data for trykkontrol så jeg kan kontrollere om grænsen er overskredet på min- eller maxvalue.
        /// </summary>
        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public DateTime CheckTime { get => _checkTime; set => _checkTime = value; }
        public int FormNo { get => _formNo; set => _formNo = value; }
        public int Bar { get => _bar; set => _bar = value; }
        public string BreakPoint { get => _breakPoint; set => _breakPoint = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }

        public PressureCheck(int processOrderNo, DateTime checkTime, int formNo, int bar, string breakPoint, int employeeNo,
            int preformNo)
        {
            ProcessOrderNo = processOrderNo;
            CheckTime = checkTime;
            FormNo = formNo;
            Bar = bar;
            BreakPoint = breakPoint;
            EmployeeNo = employeeNo;
            PreformNo = preformNo;
        }

        //Instantiating class without parameters  
        public PressureCheck()
        {
            
        }
    }
}
