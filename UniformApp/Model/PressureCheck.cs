using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class PressureCheck
    {
        private int _processNo;
        private DateTime _checkTime;
        private int _formNo;
        private int _bar;
        private string _breakPoint;
        private int _employeeNo;
        private int _preformNo;

        public int ProcessNo { get => _processNo; set => _processNo = value; }
        public DateTime CheckTime { get => _checkTime; set => _checkTime = value; }
        public int FormNo { get => _formNo; set => _formNo = value; }
        public int Bar { get => _bar; set => _bar = value; }
        public string BreakPoint { get => _breakPoint; set => _breakPoint = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }

        public PressureCheck(int processNo, DateTime checkTime, int formNo, int bar, string breakPoint, int employeeNo,
            int preformNo)
        {
            ProcessNo = processNo;
            CheckTime = checkTime;
            FormNo = formNo;
            Bar = bar;
            BreakPoint = breakPoint;
            EmployeeNo = employeeNo;
            PreformNo = preformNo;
        }
        public PressureCheck()
        {
            
        }
    }
}
