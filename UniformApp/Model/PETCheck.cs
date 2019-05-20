using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class PETCheck
    {
        private int _processOrderNo;
        private TimeSpan _checkTime;
        private int _formNo;
        private double _bottomValue;
        private double _midValue;
        private double _topValue;
        private string _comment;
        private int _employeeNo;
        private int _preformNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public TimeSpan CheckTime { get => _checkTime; set => _checkTime = value; }
        public int FormNo { get => _formNo; set => _formNo = value; }
        public double BottomValue { get => _bottomValue; set => _bottomValue = value; }
        public double MidValue { get => _midValue; set => _midValue = value; }
        public double TopValue { get => _topValue; set => _topValue = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }

        public PETCheck(int processOrderNo, TimeSpan checkTime, int formNo, double bottomValue, double midValue, double topValue, string comment, int employeeNo, int preformNo)
        {
            ProcessOrderNo = processOrderNo;
            CheckTime = checkTime;
            FormNo = formNo;
            BottomValue = bottomValue;
            MidValue = midValue;
            TopValue = topValue;
            Comment = comment;
            EmployeeNo = employeeNo;
            PreformNo = preformNo;
        }

        public PETCheck()
        {

        }
    }
}
